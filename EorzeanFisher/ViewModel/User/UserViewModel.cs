using EorzeanFisher.Models;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using EorzeanFisher.ViewModel.Popup;
using EorzeanFisher.XivApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EorzeanFisher.ViewModel.User
{
    public class UserViewModel : ViewModelBase
    {
        string members, datacenter, rank, fcName, fcTag, fcSlogan;
        ObservableCollection<FcMember> fcMembers = new ObservableCollection<FcMember>();

        Task OpenLoadingPopup() => NavigationService.NavigateToPopupAsync<LoadingViewModel>(true);
        Task RemovePopup() => NavigationService.RemovePopupAsync(true);
        Task OpenProfilPage() => NavigationService.NavigateToAsync<ProfilViewModel>(true);

        public UserViewModel()
        {
            OpenLoadingPopup();
            requestData();
            subscribeToMessage();
        }

        void subscribeToMessage()
        {
            MessagingCenter.Subscribe<App, string>((App)Application.Current, MessengerKeys.MemberSelected, OnItemSelected);
        }

        async void requestData()
        {
            JObject data = (JObject)await HttpService.GetDataAsync(
                RequestFactory.getInstance().getUrlFromType(eRequest.FREE_COMPANY_MEMBERS))
                .ConfigureAwait(false);
            setUi(data);

            await RemovePopup();
        }

        void setUi(JObject raw)
        {
            FcName = raw["FreeCompany"]["Name"].ToString();
            FcTag = raw["FreeCompany"]["Tag"].ToString();
            Members = raw["FreeCompany"]["ActiveMemberCount"].ToString();
            Datacenter = raw["FreeCompany"]["DC"].ToString();
            Rank = raw["FreeCompany"]["Rank"].ToString();
            FcSlogan = raw["FreeCompany"]["Slogan"].ToString();

            JArray list = (JArray)raw["FreeCompanyMembers"];
            foreach(var item in list)
            {
                var itemProperties = item.Children<JProperty>();

                var pName = itemProperties.FirstOrDefault(x => x.Name == "Name");
                var pAvatar = itemProperties.FirstOrDefault(x => x.Name == "Avatar");
                var pRank = itemProperties.FirstOrDefault(x => x.Name == "Rank");
                var pRankIcon = itemProperties.FirstOrDefault(x => x.Name == "RankIcon");
                var pId = itemProperties.FirstOrDefault(x => x.Name == "ID");

                FcMembers.Add(new FcMember()
                {
                    MemberName = pName.Value.ToString(),
                    MemberRank = pRank.Value.ToString(),
                    MemberPic = pAvatar.Value.ToString(),
                    MemberRankPic = pRankIcon.Value.ToString(),
                    MemberId = pId.Value.ToString()
                });
            }
        }

        void OnItemSelected(App sender, string memberId)
        {
            DataHandler.getInstance().Data = memberId;
            OpenProfilPage();
        }

        #region Ui Attributes
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

        public string FcTag
        {
            get => fcTag;
            set => SetProperty(ref fcTag, value);
        }

        public string FcName
        {
            get => fcName;
            set => SetProperty(ref fcName, value);
        }

        public string FcSlogan
        {
            get => fcSlogan;
            set => SetProperty(ref fcSlogan, value);
        }

        public ObservableCollection<FcMember> FcMembers
        {
            get => fcMembers;
            set => SetProperty(ref fcMembers, value);
        }
        #endregion
    }
}
