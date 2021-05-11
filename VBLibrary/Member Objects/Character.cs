using System.Collections.Generic;

namespace VBLibrary
{
    public class Character
    {
        public Character(long id)
        {
            this.Id = id;
        }
        public long Id { get; set; }
        public CharacterInfo Info { get; set; }
        public List<Item> ItemList = new List<Item>();
        public List<OddItem> OddList = new List<OddItem>();
    }
}
