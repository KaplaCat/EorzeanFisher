using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Models
{
    public class ClassJobsUi
    {
        public int JobID { get; set; }
        public string Icon { get { return setData(); } }
        public string Job { get; set; }
        public string CurrentLevel { get; set; }
        public double ProgressValue { get; set; }
        public string ProgressText { get; set; }
        public string NextLevel { get; set; }

        string setData()
        {
            if (JobID.Equals(19))
            {
                if (CurrentLevel.Contains("30"))
                    return "Paladin.png";
                else
                    return "Gladiator.png";
            }
            else if (JobID.Equals(21))
            {
                if (CurrentLevel.Contains("30"))
                    return "Warrior.png";
                else
                    return "Marauder.png";
            }
            else if (JobID.Equals(32))
                return "DarkKnight.png";
            else if (JobID.Equals(37))
                return "Gunbreaker.png";
            else if (JobID.Equals(24))
            {
                if (CurrentLevel.Contains("30"))
                    return "WhiteMage.png";
                else
                    return "Conjurer.png";
            }
            else if (JobID.Equals(28))
            {
                if (CurrentLevel.Contains("30"))
                    return "Scholar.png";
                else
                    return "Arcanist.png";
            }
            else if (JobID.Equals(33))
                return "Astrologian.png";
            else if (JobID.Equals(20))
            {
                if (CurrentLevel.Contains("30"))
                    return "Monk.png";
                else
                    return "Pugilist.png";
            }
            else if (JobID.Equals(22))
            {
                if (CurrentLevel.Contains("30"))
                    return "Dragoon.png";
                else
                    return "Lancer.png";
            }
            else if (JobID.Equals(30))
            {
                if (CurrentLevel.Contains("30"))
                    return "Ninja.png";
                else
                    return "Rogue.png";
            }
            else if (JobID.Equals(34))
                return "Samurai.png";
            else if (JobID.Equals(23))
            {                
                if (CurrentLevel.Contains("30"))
                    return "Bard.png";
                else
                    return "Archer.png";
            }
            else if (JobID.Equals(31))
                return "Machinist.png";
            else if (JobID.Equals(38))
                return "Dancer.png";
            else if (JobID.Equals(25))
            {
                if (CurrentLevel.Contains("30"))
                    return "BlackMage.png";
                else
                    return "Thaumaturge.png";
            }
            else if (JobID.Equals(27))
            {
                if (CurrentLevel.Contains("30"))
                    return "Summoner.png";
                else
                    return "Arcanist.png";
            }
            else if (JobID.Equals(35))
                return "RedMage.png";
            else if (JobID.Equals(36))
                return "BlueMage.png";
            else if (JobID.Equals(8))
                return "Carpenter.png";
            else if (JobID.Equals(10))
                return "Armorer.png";
            else if (JobID.Equals(11))
                return "Goldsmith.png";
            else if (JobID.Equals(12))
                return "Leatherworker.png";
            else if (JobID.Equals(13))
                return "Weaver.png";
            else if (JobID.Equals(14))
                return "Alchemist.png";
            else if (JobID.Equals(15))
                return "Culinarian.png";
            else if (JobID.Equals(16))
                return "Miner.png";
            else if (JobID.Equals(17))
                return "Botanist.png";
            else if (JobID.Equals(18))
                return "Fisher.png";
            else
                return string.Empty;
        }
    }
}
