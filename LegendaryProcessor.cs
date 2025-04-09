using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class LegendaryProcessor : IDataProcessor<LegendaryArtifact>
    {
        public List<LegendaryArtifact> LoadData(string filePath)
        {
            
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
