using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    internal class XmlProcessor : IDataProcessor<AntiqueArtifact>
    {
        XmlSerializer serializer = new XmlSerializer(typeof(AntiqueArtifact[]));

        public List<AntiqueArtifact> LoadData(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                List<AntiqueArtifact> arts = new List<AntiqueArtifact>();

                AntiqueArtifact[]? artifacts = serializer.Deserialize(fs) as AntiqueArtifact[];

                    foreach (AntiqueArtifact artifact in artifacts)
                    {
                        arts.Add(artifact);
                    }

                return arts;
            }
        }

        public void SaveData(List<AntiqueArtifact> data, string filePath)
        {
            using(FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                foreach (AntiqueArtifact artifact in data)
                {
                    artifact.Serialize();
                }
            }
        }
    }
}
