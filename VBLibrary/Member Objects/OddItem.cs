using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBLibrary
{
    public class OddItem
    {
        public OddItem(UInt32 itemHash, long itemInstance, UInt32 bucketHash, string bucketType)
        {
            this.ItemHash = itemHash;
            this.ItemInstance = itemInstance;
            this.BucketHash = bucketHash;
            this.BucketType = bucketType;
        }

        public UInt32 ItemHash { get; set; }
        public long ItemInstance { get; set; }
        public UInt32 BucketHash { get; set; }
        public string BucketType { get; set; }
    }
}
