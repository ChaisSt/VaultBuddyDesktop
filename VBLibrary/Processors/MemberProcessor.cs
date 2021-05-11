using Newtonsoft.Json.Linq;
using System;

namespace VBLibrary
{
    public class MemberProcessor
    {
        static string path = "";
        static string query = "";
        static string res = "";
        static JObject info = new JObject();
        static string imgRoot = "https://www.bungie.net";

        public static void SearchDestinyPlayer(string userName)
        {
            path = "Destiny/SearchDestinyPlayer/-1/";
            query = userName + "/";
            ApiHelper.CreateUri(path, query);

            res = Convert.ToString(ApiHelper.Search(ApiHelper.ApiClient).Result);

            info = JObject.Parse(res);
            string error = (string)info["ErrorStatus"];
            if (error == "Success")
            {
                Member.DisplayName = (string)info["Response"][0]["displayName"];
                Member.Id = (long)info["Response"][0]["membershipId"];
                Member.Type = (short)info["Response"][0]["membershipType"];
                GetProfile();
            }
        }

        public static void GetProfile()
        {
            path = "Destiny2/" + Member.Type + "/Profile/";
            query = Member.Id + "/?components=100";
            ApiHelper.CreateUri(path, query);

            res = Convert.ToString(ApiHelper.Search(ApiHelper.ApiClient).Result);

            info = JObject.Parse(res);
            string error = (string)info["ErrorStatus"];
            if (error == "Success")
            { 
                JArray characterList = (JArray)info["Response"]["profile"]["data"]["characterIds"];
                Member.CharacterList.Add(new Character((long)characterList[0]));
                Member.CharacterList.Add(new Character((long)characterList[1]));
                Member.CharacterList.Add(new Character((long)characterList[2]));

                GetCharInfo();
            }
        }

        static void GetCharInfo()
        {
            short light = 0;
            short charclass = 0;
            short race = 0;
            string emblem = "";
            string emblemBG = "";
            foreach (var character in Member.CharacterList)
            {
                path = "Destiny2/" + Member.Type + "/Profile/" + Member.Id;
                query = "/Character/" + character.Id + "/?components=200";
                ApiHelper.CreateUri(path, query);

                res = Convert.ToString(ApiHelper.Search(ApiHelper.ApiClient).Result);

                info = JObject.Parse(res);
                string error = (string)info["ErrorStatus"];
                if (error == "Success")
                {
                    emblem = imgRoot + (string)info["Response"]["character"]["data"]["emblemPath"];
                    emblemBG = imgRoot + (string)info["Response"]["character"]["data"]["emblemBackgroundPath"];
                    light = (short)info["Response"]["character"]["data"]["light"];
                    charclass = (short)info["Response"]["character"]["data"]["classType"];
                    race = (short)info["Response"]["character"]["data"]["raceType"];

                    character.Info = new CharacterInfo(light, charclass, race, emblem, emblemBG);
                }
            }
        }

        public static string LabelClassType(short classType)
        {
            string className = "";
            if (classType == 0)
            {
                className = "Titan";
            }
            else if (classType == 1)
            {
                className = "Hunter";
            }
            else
            {
                className = "Warlock";
            }
            return className;
        }

        public static string LabelRaceType(short raceType)
        {
            string raceName = "";
            if (raceType == 0)
            {
                raceName = "Human";
            }
            else if (raceType == 1)
            {
                raceName = "Awoken";
            }
            else
            {
                raceName = "Exo";
            }
            return raceName;
        }
    }
}
