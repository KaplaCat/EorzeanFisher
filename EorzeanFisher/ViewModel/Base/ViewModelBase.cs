using EorzeanFisher.Services.Dialog;
using EorzeanFisher.Services.Navigation;
using EorzeanFisher.Services.Preferences;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EorzeanFisher.ViewModel.Base
{
    public abstract class ViewModelBase : MvvmHelpers.BaseViewModel
    {
        protected readonly INavigationService NavigationService;
        protected readonly IDialogService DialogService;
        protected readonly IPreferenceService PreferenceServie;

        public ViewModelBase()
        {
            DialogService = Locator.Instance.Resolve<IDialogService>();
            NavigationService = Locator.Instance.Resolve<INavigationService>();
            PreferenceServie = Locator.Instance.Resolve<IPreferenceService>();
        }

        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
    }
}
