﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class LegendaryArtifact : Artifact
    {
        public string CurseDescription { get; set; }

        public bool IsCursed { get; set; }

        public override string Serialize()
        {
                return($"Name: {this.Name},\n" +
                    $"Id: {this.Id},\n" +
                    $"Curse Description: {this.CurseDescription}," +
                    $"Cursed?: {this.IsCursed}\n");
        }
    }
}
