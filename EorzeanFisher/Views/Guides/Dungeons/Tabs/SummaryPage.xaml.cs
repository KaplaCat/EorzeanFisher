using EorzeanFisher.Models.Guides;
using EorzeanFisher.Utils;
using EorzeanFisher.Views.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.Views.Guides.Dungeons.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SummaryPage : StackLayout
    {
        public SummaryPage()
        {
            InitializeComponent();
            
            foreach(KeyValuePair<string, List<CustomItemCard>> entry in DungeonTreasures.Treasures)
            {
                if (entry.Key.Equals(DataHandler.getInstance().DungeonSelect.Name))
                {
                    foreach(CustomItemCard view in entry.Value)
                    {
                        stack_item_card.Children.Add(view);
                    }
                    break;
                }
            }
        }

        public string TitleCardPlayers
        {
            get { return (string)GetValue(TitleCardPlayersProperty); }
            set { SetValue(TitleCardPlayersProperty, value); }
        }

        public string TitleCardLevel
        {
            get { return (string)GetValue(TitleCardLevelProperty); }
            set { SetValue(TitleCardLevelProperty, value); }
        }

        public static readonly BindableProperty TitleCardPlayersProperty = BindableProperty.Create(
                                                       nameof(TitleCardPlayers),
                                                       typeof(string),
                                                       typeof(SummaryPage),
                                                       default(string),
                                                       BindingMode.OneWay);
        public static readonly BindableProperty TitleCardLevelProperty = BindableProperty.Create(
                                                        nameof(TitleCardLevel),
                                                        typeof(string),
                                                        typeof(SummaryPage),
                                                        default(string),
                                                        BindingMode.OneWay);
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleCardPlayersProperty.PropertyName)
                custom_card_nb_players.TitleCard = TitleCardPlayers;
            else if (propertyName == TitleCardLevelProperty.PropertyName)
                custom_card_level.TitleCard = TitleCardLevel;
        }
    }
}