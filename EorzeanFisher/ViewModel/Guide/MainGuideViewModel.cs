using EorzeanFisher.MarkupExtension;
using EorzeanFisher.Models.Guides;
using EorzeanFisher.Ressources.Database.AppLists;
using EorzeanFisher.ViewModel.Base;
using EorzeanFisher.ViewModel.Guide.Dungeons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EorzeanFisher.ViewModel.Guide
{
    public class MainGuideViewModel : ViewModelBase
    {
        ObservableCollection<GuideType> listGuidesTypes = new ObservableCollection<GuideType>();

        Task OpenDungeonPage() => NavigationService.NavigateToAsync<DungeonListViewModel>(true);

        private Command openTypeList;
        public ICommand OpenTypeList => openTypeList ?? (openTypeList = new Command<string>(async param => await OnListTapped(param)));

        async Task OnListTapped(string arg)
        {
            if(arg.Equals(TranslateExtension.GetLangRessource("ITEM_GUIDE_01")))
                await OpenDungeonPage();
        }

        public MainGuideViewModel()
        {
            AddGuideList();
        }

        private void AddGuideList()
        {
            foreach (GuideType o in GuideList.Guides)
            {
                ListGuidesTypes.Add(o);
            }
        }

        public ObservableCollection<GuideType> ListGuidesTypes
        {
            get => listGuidesTypes;
            set => SetProperty(ref listGuidesTypes, value);
        }
    }
}
