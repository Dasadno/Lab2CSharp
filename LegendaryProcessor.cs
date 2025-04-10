using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static ConsoleApp7.Artifact;

namespace ConsoleApp7
{
    public class LegendaryProcessor : IDataProcessor<LegendaryArtifact>
    {
        public List<LegendaryArtifact> LoadData(string filePath)
        {
            List<LegendaryArtifact> list = new List<LegendaryArtifact>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> data = line.Split('|').ToList();
                    LegendaryArtifact artefact = new LegendaryArtifact();
                    artefact.Id = Convert.ToInt32(data[0]);
                    artefact.Name = data[1];
                    artefact.PowerLevel = Convert.ToInt32(data[2]);
                    switch (data[3])
                    {
                        case "Common":
                            artefact.Rarity = _rarity.Common; break;
                        case "Rare":
                            artefact.Rarity = _rarity.Rare; break;
                        case "Epic":
                            artefact.Rarity = _rarity.Epic; break;
                        case "Legendary":
                            artefact.Rarity = _rarity.Legendary; break;
                    }
                    artefact.CurseDescription = data[4];
                    artefact.IsCursed = bool.Parse(data[5]);
                    list.Add(artefact);
                }
            }
            return list;
        }

        public void SaveData(List<LegendaryArtifact> ls, string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (LegendaryArtifact artefact in ls)
                {
                    writer.WriteLine(artefact.Id + "|" + artefact.Name + "|" + artefact.PowerLevel + "|" + artefact.Rarity +
                        "|" + artefact.CurseDescription + "|" + artefact.IsCursed);
                }
            }
        }
    }
}
