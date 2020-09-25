using EorzeanFisher.MarkupExtension;
using EorzeanFisher.Views.Custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Models.Guides
{
    class DungeonTreasures
    {
        public static Dictionary<string, List<CustomItemCard>> Treasures = new Dictionary<string,List<CustomItemCard>>()
        {
            {  TranslateExtension.GetLangRessource("DUNGEON_01"), new List<CustomItemCard>()
            {
                new CustomItemCard() { TitleCard = "Celata pillée", ImageCard = "https://garlandtools.org/files/icons/item/40093.png" },
                new CustomItemCard() { TitleCard = "Chapeau pillé", ImageCard = "https://garlandtools.org/files/icons/item/40621.png" },
                new CustomItemCard() { TitleCard = "Gants d'assaillant", ImageCard = "https://garlandtools.org/files/icons/item/44573.png" },
                new CustomItemCard() { TitleCard = "Bagues d'oreilles pillées", ImageCard = "https://garlandtools.org/files/icons/item/48555.png" },
                new CustomItemCard() { TitleCard = "Gorgerin en laiton éthéréen", ImageCard = "https://garlandtools.org/files/icons/item/48349.png" },
                new CustomItemCard() { TitleCard = "Lunettes pillées", ImageCard = "https://garlandtools.org/files/icons/item/41336.png" },
                new CustomItemCard() { TitleCard = "Gantelets pillés", ImageCard = "https://garlandtools.org/files/icons/item/44572.png" },
                new CustomItemCard() { TitleCard = "Mitaines d'acolyte", ImageCard = "https://garlandtools.org/files/icons/item/44173.png" },
                new CustomItemCard() { TitleCard = "Boucles d'oreilles pillées", ImageCard = "https://garlandtools.org/files/icons/item/48556.png" },
                new CustomItemCard() { TitleCard = "Gourmettes en laiton éthéréennes", ImageCard = "https://garlandtools.org/files/icons/item/48853.png" }
            } }
        };
    }
}
