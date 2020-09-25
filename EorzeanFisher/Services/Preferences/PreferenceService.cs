using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.Services.Preferences
{
    public class PreferenceService : IPreferenceService
    {
        public string GetPreference(string key, string default_value = "")
        {
            return Xamarin.Essentials.Preferences.Get(key, default_value);
        }

        public bool GetPreference(string key, bool default_value = false)
        {
            return Xamarin.Essentials.Preferences.Get(key, default_value);
        }

        public void RemoveAllPreference()
        {
            Xamarin.Essentials.Preferences.Clear();
        }

        public void RemovePreference(string key)
        {
            Xamarin.Essentials.Preferences.Remove(key);
        }

        public void SetPreference(string key, string value)
        {
            Xamarin.Essentials.Preferences.Set(key, value);
        }

        public void SetPreference(string key, bool value)
        {
            Xamarin.Essentials.Preferences.Set(key, value);
        }
    }
}
