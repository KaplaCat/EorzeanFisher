using EorzeanFisher.Services.Dialog;
using EorzeanFisher.Services.Navigation;
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

        public ViewModelBase()
        {
            DialogService = Locator.Instance.Resolve<IDialogService>();
            NavigationService = Locator.Instance.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync(object navigationData) => Task.FromResult(false);
    }
}
