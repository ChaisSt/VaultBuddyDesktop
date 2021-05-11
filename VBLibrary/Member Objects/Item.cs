using System;

namespace VBLibrary
{
    public class Item
    {
        public Item(UInt32 itemHash, long itemInstance, UInt32 bucketHash, string bucketType, ItemInfo info)
        {
            this.ItemHash = itemHash;
            this.ItemInstance = itemInstance;
            this.BucketHash = bucketHash;
            this.BucketType = bucketType;
            this.itemInfo = info;
        }

        public UInt32 ItemHash { get; set; }
        public long ItemInstance { get; set; }
        public UInt32 BucketHash { get; set; }
        public string BucketType { get; set; }
        
        public ItemInfo itemInfo { get; set; }
    }
}
