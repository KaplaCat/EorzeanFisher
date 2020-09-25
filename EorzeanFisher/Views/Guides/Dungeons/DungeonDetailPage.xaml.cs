using EorzeanFisher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.Views.Guides.Dungeons
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DungeonDetailPage : TabbedPage
    {
        public DungeonDetailPage()
        {
            InitializeComponent();
            Title = DataHandler.getInstance().DungeonSelect.Name;
        }
    }
}