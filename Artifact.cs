using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public abstract class Artifact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        public enum _rarity
        {
            Common,
            Rare,
            Epic,
            Legendary
        }

        public _rarity Rarity { get; set; }

        public abstract string Serialize(); 

    }
}
