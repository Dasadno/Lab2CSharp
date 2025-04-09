using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class ModernArtifact : Artifact
    {
        public double TechLevel { get; set; }
        public string ManuFacturer { get; set; }
        

        public override void Serialize()
        {
            JsonSerializer.Serialize(this);
        }
    }
}
