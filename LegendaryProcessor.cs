using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class LegendaryProcessor : IDataProcessor<LegendaryArtifact>
    {
        public List<LegendaryArtifact> LoadData(string filePath)
        {
            List<LegendaryArtifact> ls = new List<LegendaryArtifact>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var parts = line.Split("|");
                ls.Add(new LegendaryArtifact { 
                    Id = int.Parse(parts[0]),
                    Name = parts[1],
                    PowerLevel = int.Parse(parts[2]),
                    CurseDescription = parts[3],
                    IsCursed = bool.Parse(parts[4])});
            }
            return ls;
        }

        public void SaveData(List<LegendaryArtifact> ls, string path)
        {
            foreach (var item in ls)
            {
                item.Serialize(path);
            }           
        }
    }
}
