using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.ViewModel.Guide.Dungeons
{
    public class DungeonDetailViewModel : ViewModelBase
    {
        private string level = string.Empty;
        private string players = string.Empty;

        public DungeonDetailViewModel()
        {
            Level = DataHandler.getInstance().DungeonSelect.Level;
            Players = DataHandler.getInstance().DungeonSelect.NbPlayers;
        }

        public string Level
        {
            get => level;
            set => SetProperty(ref level, value);
        }
        public string Players
        {
            get => players;
            set => SetProperty(ref players, value);
        }
    }
}
