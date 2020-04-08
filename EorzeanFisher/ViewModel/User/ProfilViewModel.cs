using EorzeanFisher.Models;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using EorzeanFisher.ViewModel.Popup;
using EorzeanFisher.XivApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EorzeanFisher.ViewModel.User
{
    public class ProfilViewModel : ViewModelBase
    {
        string Id { get; set; }
        List<ClassJobs> ClassJobsList = new List<ClassJobs>();
        string progressValue;
        double progressJob;

        public ICommand ClassMore => new AsyncCommand(OpenClassJobs);

        Task OpenLoadingPopup() => NavigationService.NavigateToPopupAsync<LoadingViewModel>(true);
        Task RemovePopup() => NavigationService.RemovePopupAsync(true);
        Task OpenClassJobs() => NavigationService.NavigateToAsync<ClassJobsViewModel>(true);

        public ProfilViewModel()
        {
            Id = (string)DataHandler.getInstance().Data;
            requestData(); 
        }

        async void requestData()
        {
            await OpenLoadingPopup();
            JObject data = (JObject)await HttpService.GetDataAsync(
                RequestFactory.getInstance().getUrlFromType(eRequest.CHARACTER_JOBS,Id))
                .ConfigureAwait(false);
            setUi(data);

            Title = data["Character"]["Name"].ToString();

            await RemovePopup();
        }

        void setUi(JObject data)
        {
            double progressComp = 0.0;
            JArray list = (JArray)data["Character"]["ClassJobs"];
            foreach (var item in list)
            {
                var itemProperties = item.Children<JProperty>();

                var pExpLevel = itemProperties.FirstOrDefault(x => x.Name == "ExpLevel");
                var pExpLevelMax = itemProperties.FirstOrDefault(x => x.Name == "ExpLevelMax");
                var pExpLevelTogo = itemProperties.FirstOrDefault(x => x.Name == "ExpLevelTogo");
                var pIsSpecialised = itemProperties.FirstOrDefault(x => x.Name == "IsSpecialised");
                var pJobID = itemProperties.FirstOrDefault(x => x.Name == "JobID");
                var pLevel = itemProperties.FirstOrDefault(x => x.Name == "Level");

                ClassJobsList.Add(new ClassJobs()
                {
                    ExpLevel = (long)pExpLevel.Value,
                    ExpLevelMax = (long)pExpLevelMax.Value,
                    ExpLevelTogo = (long)pExpLevelTogo.Value,
                    IsSpecialised = (bool)pIsSpecialised.Value,
                    JobID = (int)pJobID.Value,
                    Level = (int)pLevel.Value
                });

                double comp = 0.0;
                if(((int)pJobID.Value).Equals(36))
                    comp = (((int)pLevel.Value) / 60) * 100;
                else
                    comp = (((int)pLevel.Value) / 80) * 100;
                progressComp += comp;

            }
            ProgressJob = (progressComp / 2900);
            ProgressValue = (ProgressJob*100).ToString("0.0") + " %";
            DataHandler.getInstance().Data = ClassJobsList;
        }

        #region Ui Attributes
        public double ProgressJob
        {
            get => progressJob;
            set => SetProperty(ref progressJob, value);
        }
        public string ProgressValue
        {
            get => progressValue;
            set => SetProperty(ref progressValue, value);
        }
        #endregion
    }
}
