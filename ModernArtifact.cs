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
        

        public override void Serialize(string path)
        {
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();

            using(StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, this);
            }
        }
    }
}
