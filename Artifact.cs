using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal abstract class Artifact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PowerLevel { get; set; }

        public enum Rarity
        {
            Common,
            Rare,
            Epic,
            Legendary
        }

        public abstract void Serialize(string path); 

    }
}
