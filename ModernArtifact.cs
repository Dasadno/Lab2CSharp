using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class ModernArtifact : Artifact
    {
        public double TechLevel { get; set; }
        public string ManuFacturer { get; set; }
        

        public override string Serialize()
        {
            return "Id: " + Id + " Name: " + Name + " PowerLevel: "
                + PowerLevel + " Rarity: " + Rarity + " Tech Level: "
                + TechLevel + " Manufacturer: " + ManuFacturer;
        }
    }
}
