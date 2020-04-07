using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.Views.User
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilPage : ContentPage
    {
        public ProfilPage()
        {
            InitializeComponent();
        }

        private async void FrameTappedClass(object sender, EventArgs e)
        {
            ((Frame)sender).BackgroundColor = (Color)Application.Current.Resources["ela_red"];
            await Task.Delay(50);
            ((Frame)sender).BackgroundColor = (Color)Application.Current.Resources["ela_red_opac"];
        }

        private async void FrameTappedMinion(object sender, EventArgs e)
        {
            ((Frame)sender).BackgroundColor = (Color)Application.Current.Resources["ela_dark_blue"];
            await Task.Delay(50);
            ((Frame)sender).BackgroundColor = (Color)Application.Current.Resources["ela_dark_blue_opac"];
        }

        private async void FrameTappedMount(object sender, EventArgs e)
        {
            ((Frame)sender).BackgroundColor = (Color)Application.Current.Resources["design_back_light"];
            await Task.Delay(50);
            ((Frame)sender).BackgroundColor = (Color)Application.Current.Resources["design_back_light_opac"];
        }
    }
}