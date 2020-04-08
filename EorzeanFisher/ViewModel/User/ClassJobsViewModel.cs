using EorzeanFisher.Models;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EorzeanFisher.ViewModel.User
{

    public class ClassJobsViewModel : ViewModelBase
    {
        ObservableCollection<ClassJobsUi> dpsList = new ObservableCollection<ClassJobsUi>();
        List<int> dpsId = new List<int>() { 20,22,30,34,23,31,38,25,27,35,36 };

        public ClassJobsViewModel()
        {
            var listData = (List<ClassJobs>)DataHandler.getInstance().Data;

            foreach(ClassJobs item in listData)
            {
                if (dpsId.Contains(item.JobID))
                {
                    try
                    {
                        if (item.ExpLevelTogo.Equals(0))
                        {
                            DpsList.Add(new ClassJobsUi()
                            {
                                JobID = item.JobID,
                                CurrentLevel = "Lvl." + (item.Level).ToString(),
                                Job = item.Name,
                                NextLevel = "Lvl." + (item.Level + 1).ToString(),
                                ProgressValue = 0,
                                ProgressText = "0 %"
                            });
                        }
                        else
                        {
                            DpsList.Add(new ClassJobsUi()
                            {
                                JobID = item.JobID,
                                CurrentLevel = "Lvl." + (item.Level).ToString(),
                                Job = item.Name,
                                NextLevel = "Lvl." + (item.Level + 1).ToString(),
                                ProgressValue = item.ExpLevel / item.ExpLevelTogo,
                                ProgressText = (item.ExpLevel / item.ExpLevelTogo * 100).ToString("0.0") + " %"
                            });
                        }
                        
                    }
                    catch(Exception e)
                    {

                    }
                    
                }
            }
        }

        #region Ui Attributes
        public ObservableCollection<ClassJobsUi> DpsList
        {
            get => dpsList;
            set => SetProperty(ref dpsList, value);
        }
        #endregion
    }
}
