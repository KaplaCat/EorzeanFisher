using EorzeanFisher.Settings;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using EorzeanWeather;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EorzeanFisher.ViewModel
{
    public class MainViewModel : ViewModelBase    
    {
        string versionApp;

        public MainViewModel()
        {
            VersionApp = AppSettings.getAppVersion();
                       
        }

        #region Ui Attributes
        public string VersionApp
        {
            get => versionApp;
            set => SetProperty(ref versionApp, value);
        }
        #endregion
    }
}
