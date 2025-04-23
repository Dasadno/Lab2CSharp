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
          if (!Artifacts.Contains(artifact))
          {
              Artifacts.Add(artifact);
          }
      }
      foreach (Artifact artifact in jsonProcessor.LoadData(jsonPath))
      {
          Console.WriteLine(artifact);
          if (!Artifacts.Contains(artifact))
          {
              Artifacts.Add(artifact);
          }
      }
      foreach (var artifact in xmlProcessor.LoadData(xmlPath))
      {
          Console.WriteLine(artifact);
          if (!Artifacts.Contains(artifact))
          {
              Artifacts.Add(artifact);
          }
      }

  }

  public void GenerateReport(string txtPath)
  {
      

      using (StreamWriter sw = new StreamWriter(txtPath))
      {
          foreach (Artifact artifact in Artifacts)
          {
              sw.WriteLine($"artifact: {artifact.Name}, Id: {artifact.Id},\n" +
                  $"Rarity: {artifact.Rarity}, Power Level: {artifact.PowerLevel}\n\n");
          }
      }
  }

  public void findCursedArtifacts(string txtPath)
  {

      var CursedArtifacts = Artifacts.Where(x => x.PowerLevel > 50 && x.GetType() == typeof(LegendaryArtifact)).ToList();
      foreach (LegendaryArtifact artifact in CursedArtifacts)
      {
          if (artifact.IsCursed)
          {
              Console.WriteLine($"Artifact: {artifact.Name}, Is Cursed,\nCurse Description {artifact.CurseDescription}\n" +
                  $"{artifact.PowerLevel}");
          }
      }
     
  }

  public void GroupByRarity()
  {
      var RaritySort = Artifacts.GroupBy(x => x.Rarity).ToList();
      
      foreach(LegendaryArtifact artifact in RaritySort)
      {
          Console.WriteLine($"Artifact: {artifact.Name}, Rarity: {artifact.Rarity}");
      }

  }


  public void TopByPower(int count)
  {
      var Sort = Artifacts.OrderBy(x => x.PowerLevel).ToList();

      foreach(Artifact artifact in Sort)
      {
          int i = 1;
          Console.WriteLine($"Artifact Number{i} by power. Name: {artifact.Name}, Power: {artifact.PowerLevel}");
          if (i >= count)
          {
              break;
          }
          i++;
      }
  }

}
