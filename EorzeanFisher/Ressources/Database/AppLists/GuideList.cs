using EorzeanFisher.MarkupExtension;
using EorzeanFisher.Models.Guides;
using EorzeanFisher.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Ressources.Database.AppLists
{
    public class GuideList
    {
        public static List<GuideType> Guides = new List<GuideType>()
        {
            new GuideType() { GuideTypeIcon = FontAwesomeIcons.Dungeon, GuideTypeName = TranslateExtension.GetLangRessource("ITEM_GUIDE_01") },
            new GuideType() { GuideTypeIcon = FontAwesomeIcons.Angry, GuideTypeName = TranslateExtension.GetLangRessource("ITEM_GUIDE_02")}
        };
    }
}
