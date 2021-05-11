using Newtonsoft.Json.Linq;
using System;

namespace VBLibrary
{
    public class InventoryProcessor
    {
        static string path = "";
        static string query = "";
        static string res = "";
        static string imgRoot = "https://www.bungie.net";

        public static void GetItems()
        {
            UInt32 itemHash = 0, bucketHash = 0;
            long itemInstance = 0;
            string bucketType = "";
            JObject info = new JObject();
            foreach (var character in Member.CharacterList)
            {
                int count2 = 0;
                path = "Destiny2/" + Member.Type + "/Profile/" + Member.Id;
                query = "/Character/" + character.Id + "/?components=205";
                ApiHelper.CreateUri(path, query);
                res = Convert.ToString(ApiHelper.Search(ApiHelper.ApiClient).Result);
                info = JObject.Parse(res);
                string error = (string)info["ErrorStatus"];
                if (error == "Success")
                {
                    while (count2 < 16)
                    {
                        itemHash = (UInt32)info["Response"]["equipment"]["data"]["items"][count2]["itemHash"];
                        itemInstance = (long)info["Response"]["equipment"]["data"]["items"][count2]["itemInstanceId"];
                        bucketHash = (UInt32)info["Response"]["equipment"]["data"]["items"][count2]["bucketHash"];
                        bucketType = GetBucketInfo((int)bucketHash);
                        
                        if(bucketType == "Subclass" || bucketType == "Clan Banners" || bucketType == "Seasonal Artifact" ||
                            bucketType == "Emblems" || bucketType == "Finishers" || bucketType == "Emotes")
                        {
                            character.OddList.Add(new OddItem(itemHash, itemInstance, bucketHash, bucketType));
                        }
                        else
                        {
                            ItemInfo itemInfo = GetItemInfo((int)itemHash);
                            character.ItemList.Add(new Item(itemHash, itemInstance, bucketHash, bucketType, itemInfo));
                        }
                        count2++;
                    }
                } 
            }
        }

        public static string GetBucketInfo(int hash)
        {
            string table = "DestinyInventoryBucketDefinition";
            string data = ManifestAccess.ReadData(table, hash);

            JObject info = JObject.Parse(data);
            string type = (string)info["displayProperties"]["name"];

            return type;
        }

        public static ItemInfo GetItemInfo(int hash)
        {
            string table = "DestinyInventoryItemDefinition";
            string data = ManifestAccess.ReadData(table, hash);
            string desc = "", name = "", icon = "", iconWM = "", itemType = "", tierType = "", gearType = "";
            JObject info = JObject.Parse(data);

            desc = (string)info["displayProperties"]["description"];
            name = (string)info["displayProperties"]["name"];
            icon = imgRoot + (string)info["displayProperties"]["icon"];
            itemType = (string)info["itemTypeDisplayName"];
            tierType = (string)info["inventory"]["tierTypeName"];
            gearType = imgRoot + (string)info["screenshot"];

            if (info["iconWatermark"] == null)
            {
                iconWM = "none";
                //iconWM = imgRoot + (string)info[""]["quality"]["displayVersionWatermarkIcons"];
            }
            else
            {
                iconWM = imgRoot + (string)info["iconWatermark"];
            }

            ItemInfo itemInfo = new ItemInfo(desc, name, icon, iconWM, itemType, tierType, gearType);
            return itemInfo;
        }

        //This does nothing as of now.
        //public static void GetC1ItemInfo()
        //{
        //    path = "Destiny2/" + Member.Type + "/Profile/" + Member.Id;
        //    query = "/Character/" + Character1.Id + "/Inventory/" + C1Items.I1Instance;
        //    ApiHelper.CreateUri(path, query);

        //    res = Convert.ToString(ApiHelper.Search(ApiHelper.ApiClient).Result);

        //    info = JObject.Parse(res);
        //    string error = (string)info["ErrorStatus"];
        //    if (error == "Success")
        //    {

        //    }
        //}
    }
}
