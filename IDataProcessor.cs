using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IDataProcessor<T> where T : Artifact
    {
       public List<T> LoadData(string filePath);
       public void SaveData(List<T> data, string filePath);

    }
}
