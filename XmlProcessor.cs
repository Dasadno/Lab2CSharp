using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    public class XmlProcessor : IDataProcessor<AntiqueArtifact>
    {
        public List<AntiqueArtifact> LoadData(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<AntiqueArtifact>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<AntiqueArtifact>? data = xmlSerializer.Deserialize(fs) as List<AntiqueArtifact>;
                return data;
            }
        }

        public void SaveData(List<AntiqueArtifact> data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<AntiqueArtifact>));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, data);
            }
        }
    }
}
