using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBLibrary
{
    public class CharacterInfo
    {
        public CharacterInfo(short light, short charClass, short race, string emblem, string emblemBG )
        {
            this.Light = light;
            this.Class = charClass;
            this.Race = race;
            this.Emblem = emblem;
            this.EmblemBG = emblemBG;
        }

        public short Light { get; set; }
        public short Class { get; set; }
        public short Race { get; set; }
        public string Emblem { get; set; }
        public string EmblemBG { get; set; }
    }
}
