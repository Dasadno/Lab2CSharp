using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    internal class AntiqueArtifact : Artifact
    {
        public int Age { get; set; }
        public string OriginRealm { get; set; }

        public override void Serialize()
        {
            using (FileStream fs = new FileStream("content.txt", FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AntiqueArtifact));
                serializer.Serialize(fs, this);
            }

        }
    }
}
