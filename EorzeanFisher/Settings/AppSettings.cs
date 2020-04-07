using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EorzeanFisher.Settings
{
    static class AppSettings
    {
        public static string lang = "fr-FR";
               

        const string MAJOR = "1.";
        const string MINOR = "0.";
        const string MAJ = "0";

        public static string getAppVersion()
        {
            return MAJOR + MINOR + MAJ;
        }

        public static string getApiKey()
        {
            return string.Empty;
        }
    }
}
