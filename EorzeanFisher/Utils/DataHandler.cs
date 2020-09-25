using EorzeanFisher.Models.Guides;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Utils
{
    public class DataHandler
    {
        static DataHandler instance = null;

        public static DataHandler getInstance()
        {
            if (instance == null)
                instance = new DataHandler();
            return instance;
        }

        public object Data { get; set; }
        public DungeonType DungeonSelect { get; set; } = null;
    }
}
