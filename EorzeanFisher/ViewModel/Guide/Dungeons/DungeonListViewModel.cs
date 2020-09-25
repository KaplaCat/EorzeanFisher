using EorzeanFisher.MarkupExtension;
using EorzeanFisher.Models.Guides;
using EorzeanFisher.Ressources.Database.AppLists;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EorzeanFisher.ViewModel.Guide.Dungeons
{
    public class DungeonListViewModel : ViewModelBase
    {
        ObservableCollection<DungeonType> listDungeonsType = new ObservableCollection<DungeonType>();

        Task OpenDetailPage() => NavigationService.NavigateToAsync<DungeonDetailViewModel>(true);

        private Command openDungeonDetail;
        public ICommand OpenDungeonDetail => openDungeonDetail ?? (openDungeonDetail = new Command<string>(async param => await OnListTapped(param)));

        async Task OnListTapped(string arg)
        {
            if (arg.Equals(TranslateExtension.GetLangRessource("DUNGEON_01")))
            {
                DataHandler.getInstance().DungeonSelect = DungeonList.Dungeons.Find(x => x.Name.Equals(TranslateExtension.GetLangRessource("DUNGEON_01")));
                await OpenDetailPage();
            }
        }

        public DungeonListViewModel()
        {
            AddGuideList();
        }

        private void AddGuideList()
        {
            foreach (DungeonType o in DungeonList.Dungeons)
            {
                ListDungeonsType.Add(o);
            }
        }

        public ObservableCollection<DungeonType> ListDungeonsType
        {
            get => listDungeonsType;
            set => SetProperty(ref listDungeonsType, value);
        }
    }
}
