using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFShapeView;

namespace EorzeanFisher
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnItemTapped(object sender, EventArgs e)
        {
            ((ShapeView)sender).Color = (Color)Application.Current.Resources["ela_light_grey"];
            await Task.Delay(50);
            ((ShapeView)sender).Color = (Color)Application.Current.Resources["ela_white"];
        }
    }
}
