using EorzeanFisher.Models.Guides;
using EorzeanFisher.Ressources.Database.AppLists;
using EorzeanFisher.Settings;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using EorzeanFisher.ViewModel.Guide;
using EorzeanWeather;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EorzeanFisher.ViewModel
{
    public class MainViewModel : ViewModelBase    
    {
        string versionApp;

        public ICommand GuideClick => new AsyncCommand(OpenNfcConfigAsync);
        Task OpenNfcConfigAsync() => NavigationService.NavigateToAsync<MainGuideViewModel>(true);

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
