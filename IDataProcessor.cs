using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal interface IDataProcessor<T> where T : Artifact
    {
        List<T> LoadData(string filePath);
        void SaveData(List<T> data, string filePath);

    }
}
