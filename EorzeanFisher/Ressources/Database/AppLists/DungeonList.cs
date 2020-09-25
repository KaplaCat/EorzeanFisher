using EorzeanFisher.MarkupExtension;
using EorzeanFisher.Models.Guides;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Ressources.Database.AppLists
{
    public class DungeonList
    {
        public static List<DungeonType> Dungeons = new List<DungeonType>()
        {
            new DungeonType() { Name = TranslateExtension.GetLangRessource("DUNGEON_01"), Level = "Lv.15", NbPlayers = "1-4", NbTresaures = 7 },
            new DungeonType() {Name = TranslateExtension.GetLangRessource("DUNGEON_02"), Level = "Lv.16", NbPlayers = "1-4" }
        };
    }
}
