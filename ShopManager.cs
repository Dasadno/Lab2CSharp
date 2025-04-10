using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class ShopManager
    {
        List<Artifact> Artifacts = new List<Artifact>();

        public void LoadAllData(string jsonPath, string xmlPath, string txtPath)
        {
            LegendaryProcessor legendaryProcessor = new LegendaryProcessor();
            JsonProcessor jsonProcessor = new JsonProcessor();
            XmlProcessor xmlProcessor = new XmlProcessor();

            foreach (Artifact artifact in legendaryProcessor.LoadData(txtPath))
            {
                Console.WriteLine(artifact);
            }
            foreach (Artifact artifact in jsonProcessor.LoadData(jsonPath))
            {
                Console.WriteLine(artifact);
            }
            foreach (var artifact in xmlProcessor.LoadData(xmlPath))
            {
                Console.WriteLine(artifact);
            }

        }

        public void GenerateReport()
        {

        }

    }
}
