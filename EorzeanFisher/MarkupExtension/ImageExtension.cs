using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.MarkupExtension
{
    [ContentProperty(nameof(Source))]
    public class ImageExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source, typeof(ImageExtension).GetTypeInfo().Assembly);

            return imageSource;
        }

        public static ImageSource GetImageRessource(string key)
        {
            var imageSource = ImageSource.FromResource($"EorzeanFisher.Ressources.Fish.{key}.png", typeof(ImageExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
