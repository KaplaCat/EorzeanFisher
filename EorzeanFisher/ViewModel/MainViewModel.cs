using EorzeanFisher.Models;
using EorzeanFisher.Settings;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using EorzeanFisher.ViewModel.User;
using EorzeanFisher.XivApi;
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
        string hour;

        public ICommand UserClick => new AsyncCommand(OpenUserPage);
        Task OpenUserPage() => NavigationService.NavigateToAsync<UserViewModel>(true);

        public MainViewModel()
        {
            VersionApp = AppSettings.getAppVersion();
            Task.Run(() => ActualDateEorzea());                        
        }

        async void ActualDateEorzea()
        {
            while (true)
            {
                Hour = DateTime.Now.ToEorzeaTime().ToString("HH:mm");
                await Task.Delay(3000);
            }
        }

        #region Ui Attributes
        public string VersionApp
        {
            get => versionApp;
            set => SetProperty(ref versionApp, value);
        }
        public string Hour
        {
            get => hour;
            set => SetProperty(ref hour, value);
        }
        #endregion
    }
}
