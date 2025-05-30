﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    public class AntiqueArtifact : Artifact
    {
        public int Age { get; set; }
        public string OriginRealm { get; set; }

        public override string Serialize()
        {
            return "Id: " + Id + " Name: " + Name + " PowerLevel: "
                + PowerLevel + " Rarity: " + Rarity + " Age: "
                + Age + " Origin Realm: " + OriginRealm;
        }
    }
}
