using EorzeanFisher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void MemberSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (FcMember)e.SelectedItem;
            MessagingCenter.Send<App, string>((App)Application.Current, MessengerKeys.MemberSelected, item.MemberId);
        }      
    }
}