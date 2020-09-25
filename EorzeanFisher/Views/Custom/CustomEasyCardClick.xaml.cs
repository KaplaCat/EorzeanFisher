using EorzeanFisher.MarkupExtension;
using EorzeanFisher.Services.Preferences;
using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.Views.Custom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomEasyCardClick : Frame
    {
        protected readonly IPreferenceService PreferenceServie;
        public CustomEasyCardClick()
        {
            InitializeComponent();
            PreferenceServie = Locator.Instance.Resolve<IPreferenceService>();
            IsChecked = PreferenceServie.GetPreference(PreferenceKey.Dungeon_01_Tr_01,false);
            CheckPref(false);
        }

        private bool isChecked;
        public bool IsChecked { get { return isChecked; } 
            set
            { 
                isChecked = value;
                PreferenceServie.SetPreference(PreferenceKey.Dungeon_01_Tr_01, value);
            } 
        }

        public string TitleCard
        {
            get { return (string)GetValue(TitleCardProperty); }
            set { SetValue(TitleCardProperty, value); }
        }

        public string IconCard
        {
            get { return (string)GetValue(IconCardProperty); }
            set { SetValue(IconCardProperty, value); }
        }

        

        public static readonly BindableProperty TitleCardProperty = BindableProperty.Create(
                                                       nameof(TitleCard),
                                                       typeof(string),
                                                       typeof(CustomEasyCard),
                                                       default(string),
                                                       BindingMode.OneWay);
        public static readonly BindableProperty IconCardProperty = BindableProperty.Create(
                                                        nameof(IconCard),
                                                        typeof(string),
                                                        typeof(CustomEasyCard),
                                                        default(string),
                                                        BindingMode.OneWay);
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleCardProperty.PropertyName)
                label_title_card.Text = TitleCard;
            else if (propertyName == IconCardProperty.PropertyName)
                label_shape_card.Text = IconCard;
        }

        private void CheckPref(bool tapped)
        {
            if(tapped)
            {
                if (!this.IsChecked)
                {
                    GreenFrame();
                    this.IsChecked = true;
                }
                else
                {
                    RedFrame();
                    this.IsChecked = false;
                }
            }
            else
            {
                if (this.IsChecked)
                    GreenFrame();
                else
                    RedFrame();
            }
        }

        private void RedFrame()
        {
            frame_card.BackgroundColor = (Color)Application.Current.Resources["ela_red_opac"];
            frame_card.BorderColor = (Color)Application.Current.Resources["ela_red_opac"];
            shape_card.BorderColor = (Color)Application.Current.Resources["ela_red"];
            label_shape_card.Text = FontAwesomeIcons.Times;
            label_shape_card.TextColor = (Color)Application.Current.Resources["ela_red"];
        }

        private void GreenFrame()
        {
            frame_card.BackgroundColor = (Color)Application.Current.Resources["design_green_opac"];
            frame_card.BorderColor = (Color)Application.Current.Resources["design_green_opac"];
            shape_card.BorderColor = (Color)Application.Current.Resources["design_green"];
            label_shape_card.Text = FontAwesomeIcons.Check;
            label_shape_card.TextColor = (Color)Application.Current.Resources["design_green"];
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CheckPref(true); 
        }
    }
}