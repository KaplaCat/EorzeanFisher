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
    public partial class CustomEasyCard : Frame
    {
        public CustomEasyCard()
        {
            InitializeComponent();
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
                label_icone_card.Text = IconCard;
        }
    }
}