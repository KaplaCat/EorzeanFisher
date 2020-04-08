using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Models
{
    public class ClassJobs
    {
        string name;
        public long ExpLevel { get; set; }
        public long ExpLevelMax { get; set; }
        public long ExpLevelTogo { get; set; }
        public bool IsSpecialised { get; set; }
        public int JobID { get; set; }
        public int Level { get; set; }
        public string Name
        {
            get { return setData(); }
        }

        string setData()
        {
            if (JobID.Equals(19))
            {
                if (Level >= 30)
                    return "Paladin";
                else
                    return "Gladiateur";
            }
            else if (JobID.Equals(21))
            {
                if (Level >= 30)
                    return "Guerrier";
                else
                    return "Maraudeur";
            }
            else if (JobID.Equals(32))
                return "Chevalier noir";
            else if (JobID.Equals(37))
                return "Pistosabreur";
            else if (JobID.Equals(24))
            {
                if (Level >= 30)
                    return "Mage Blanc";
                else
                    return "Élémentaliste";
            }
            else if (JobID.Equals(28))
            {
                if (Level >= 30)
                    return "Erudit";
                else
                    return "Arcaniste";
            }
            else if (JobID.Equals(33))
                return "Astromancien";
            else if (JobID.Equals(20))
            {
                if (Level >= 30)
                    return "Moine";
                else
                    return "Pugiliste";
            }
            else if (JobID.Equals(22))
            {
                if (Level >= 30)
                    return "Chevalier dragon";
                else
                    return "Maitre d'hast";
            }
            else if (JobID.Equals(30))
            {
                if (Level >= 30)
                    return "Ninja";
                else
                    return "Surineur";
            }
            else if (JobID.Equals(34))
                return "Samourai";
            else if (JobID.Equals(23))
            {
                if (Level >= 30)
                    return "Barde";
                else
                    return "Archer";
            }
            else if (JobID.Equals(31))
                return "Machiniste";
            else if (JobID.Equals(38))
                return "Danseur";
            else if (JobID.Equals(25))
            {
                if (Level >= 30)
                    return "Mage noir";
                else
                    return "Occultiste";
            }
            else if (JobID.Equals(27))
            {
                if (Level >= 30)
                    return "Invocateur";
                else
                    return "Arcaniste";
            }
            else if (JobID.Equals(35))
                return "Mage rouge";
            else if (JobID.Equals(36))
                return "Mage bleu";
            else if (JobID.Equals(8))
                return "Menuisier";
            else if (JobID.Equals(10))
                return "Armurier";
            else if (JobID.Equals(11))
                return "Orfèvre";
            else if (JobID.Equals(12))
                return "Tanneur";
            else if (JobID.Equals(13))
                return "Couturier";
            else if (JobID.Equals(14))
                return "Alchimiste";
            else if (JobID.Equals(15))
                return "Cuisinier";
            else if (JobID.Equals(16))
                return "Mineur";
            else if (JobID.Equals(17))
                return "Botaniste";
            else if (JobID.Equals(18))
                return "Pêcheur";
            else
                return string.Empty;
        }
    }
}
