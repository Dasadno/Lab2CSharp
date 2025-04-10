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
            XmlSerializer serializer = new XmlSerializer(typeof(AntiqueArtifact));

            List<AntiqueArtifact> arts = new List<AntiqueArtifact>();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                AntiqueArtifact[]? artifacts = serializer.Deserialize(fs) as AntiqueArtifact[];

                    foreach (AntiqueArtifact artifact in artifacts)
                    {
                        arts.Add(artifact);
                    }

                
            }
            return arts;
        }

        public void SaveData(List<AntiqueArtifact> data, string filePath)
        {
                foreach (AntiqueArtifact artifact in data)
                {
                    artifact.Serialize(filePath);
                }
        }
    }
}
