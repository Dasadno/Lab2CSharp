namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopManager shopManager = new ShopManager();
            LegendaryProcessor legProcessor = new LegendaryProcessor();
            XmlProcessor xmlProcessor = new XmlProcessor();
            JsonProcessor jsonProcessor = new JsonProcessor();

            List<LegendaryArtifact> legendaryArtifacts = new List<LegendaryArtifact>();
            List<AntiqueArtifact> antiArtifacts = new List<AntiqueArtifact>();
            List<ModernArtifact> modernArtifacts = new List<ModernArtifact>();

            for (int i = 0; i < 10; i++)
            {
                legendaryArtifacts.Add(new LegendaryArtifact { 
                    IsCursed = true,
                    CurseDescription = "asd",
                    Id = i,
                    Name = $"leg{i}",
                    PowerLevel = i,
                    Rarity = Artifact._rarity.Legendary});
            }

            for (int i = 0; i < 10; i++)
            {
                antiArtifacts.Add(new AntiqueArtifact { 
                    PowerLevel = i,
                    Name = $"Antique{i}",
                    Id = i,
                    Age = 52,
                    OriginRealm = $"area{i}",
                    Rarity = Artifact._rarity.Common});
            }

            for (int i = 0; i < 10; i++)
            {
                modernArtifacts.Add(new ModernArtifact { Id = i,
                    ManuFacturer = $"debili{i}",
                    Name = $"Debil{i}",
                    PowerLevel = i,
                    TechLevel = i,
                    Rarity = Artifact._rarity.Rare});
            }

            jsonProcessor.SaveData(modernArtifacts, "jsonContent.json");
            xmlProcessor.SaveData(antiArtifacts, "xmlContent.xml");
            legProcessor.SaveData(legendaryArtifacts, "txtContent.txt");

            shopManager.LoadAllData("jsonContent.json", "xmlContent.xml", "txtContent.txt");
        }
    }
}
