using EorzeanFisher.ViewModel.Base;
using EorzeanFisher.XivApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EorzeanFisher.ViewModel.User
{
    public class UserViewModel : ViewModelBase
    {
        string members, datacenter, rank;

        private readonly EventWaitHandle waitHandle = new AutoResetEvent(false);
        public UserViewModel()
        {
            requestData();
        }

        async void requestData()
        {
            object data = await HttpService.GetDataAsync(RequestFactory.getInstance().getUrlFromType(eRequest.FREE_COMPANY, string.Empty)).ConfigureAwait(false);

        }

        void setUi(object raw)
        {
          /*  Members = raw.FreeCompany.ActiveMemberCount;
            Datacenter = raw.FreeCompany.DC;
            Rank = raw.FreeCompany.Rank;*/
        }

        public string Members
        {
            get => members;
            set => SetProperty(ref members, value);
        }

        public string Datacenter
        {
            get => datacenter;
            set => SetProperty(ref datacenter, value);
        }

        public string Rank
        {
            get => rank;
            set => SetProperty(ref rank, value);
        }

    }
}
