using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBLibrary
{
    public class ItemInfo
    {
        public ItemInfo(string itemDesc, string itemName, string itemIcon, 
            string iconWM, string itemType, string tierType, string gearType)
        {
            this.ItemDesc = itemDesc;
            this.ItemName = itemName;
            this.ItemIcon = itemIcon;
            this.IconWM = iconWM;
            this.ItemType = itemType;
            this.TierType = tierType;
            this.GearType = gearType;
        }

        public string GearType { get; set; }
        public string ItemDesc { get; set; }
        public string ItemName { get; set; }
        public string ItemIcon { get; set; }
        public string IconWM { get; set; }
        public string ItemType { get; set; }
        public string TierType { get; set; }
    }
}
