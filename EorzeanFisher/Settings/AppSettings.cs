using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EorzeanFisher.Settings
{
    static class AppSettings
    {
        public static string lang = "fr-FR";
        
        static string XIVAPI_KEY = "5966da3db81c45808f21087729e6cb88e0ada6648cd247f8803cfdea76f8694b";

        const string MAJOR = "1.";
        const string MINOR = "0.";
        const string MAJ = "0";

        public static string getAppVersion()
        {
            return MAJOR + MINOR + MAJ;
        }

        public static string getApiKey()
        {
            return XIVAPI_KEY;
        }
    }
}
