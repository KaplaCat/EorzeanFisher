using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Models.Guides
{
    public class DungeonType
    {
        public string Name { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string NbPlayers { get; set; } = string.Empty;
        public int NbTresaures { get; set; } = 1;
    }
}
