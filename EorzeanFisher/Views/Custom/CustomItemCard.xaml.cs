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
    public partial class CustomItemCard : Frame
    {
        protected readonly IPreferenceService PreferenceServie;
        public CustomItemCard()
        {
            InitializeComponent();
            PreferenceServie = Locator.Instance.Resolve<IPreferenceService>();
        }
        public bool IsChecked { get; set; } = false;

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

        public string ImageCard
        {
            get { return (string)GetValue(ImageCardProperty); }
            set { SetValue(ImageCardProperty, value); }
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
        public static readonly BindableProperty ImageCardProperty = BindableProperty.Create(
                                                        nameof(ImageCard),
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
            else if (propertyName == ImageCardProperty.PropertyName)
                image_card.Source = ImageCard;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (label_shape_card.Text == FontAwesomeIcons.Times)
            {
                frame_card.BackgroundColor = (Color)Application.Current.Resources["design_green_opac"];
                frame_card.BorderColor = (Color)Application.Current.Resources["design_green_opac"];
                shape_card.BorderColor = (Color)Application.Current.Resources["design_green"];
                label_shape_card.Text = FontAwesomeIcons.Check;
                label_shape_card.TextColor = (Color)Application.Current.Resources["design_green"];
                this.IsChecked = true;
                
            }
            else
            {
                frame_card.BackgroundColor = (Color)Application.Current.Resources["ela_red_opac"];
                frame_card.BorderColor = (Color)Application.Current.Resources["ela_red_opac"];
                shape_card.BorderColor = (Color)Application.Current.Resources["ela_red"];
                label_shape_card.Text = FontAwesomeIcons.Times;
                label_shape_card.TextColor = (Color)Application.Current.Resources["ela_red"];
                this.IsChecked = false;
            }
        }
    }
}