using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace ConsoleApp7
{
    public class JsonProcessor : IDataProcessor<ModernArtifact>
    {
       
        public List<ModernArtifact> LoadData(string path)
        {
            List<ModernArtifact> artifacts = JsonConvert.DeserializeObject<List<ModernArtifact>>(path);

            return artifacts;
        }

        public void SaveData(List<ModernArtifact> data, string filePath)
        {
                foreach (ModernArtifact artifact in data)
                {
                    artifact.Serialize(filePath);
                }
        }
    }
}
