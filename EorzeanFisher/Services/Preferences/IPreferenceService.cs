using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Services.Preferences
{
    public interface IPreferenceService
    {
        void SetPreference(string key, string value);
        string GetPreference(string key, string default_value = "");
        bool GetPreference(string key, bool default_value = false);
        void RemovePreference(string key);
        void RemoveAllPreference();
        void SetPreference(string key, bool value);
    }
}
