using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBLibrary
{
    public class Member
    {
        public static string DisplayName { get; set; }
        public static long Id { get; set; }
        public static short Type { get; set; }

        public static List<Character> CharacterList = new List<Character>();
    }
}
