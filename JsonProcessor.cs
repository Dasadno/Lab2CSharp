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
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<ModernArtifact>>(json);
        }

        public void SaveData(List<ModernArtifact> data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
