using EorzeanFisher.Settings;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EorzeanFisher.MarkupExtension
{
	[ContentProperty("Text")]
	public class TranslateExtension : IMarkupExtension
	{
		public string Text { get; set; }
		public string StringFormat { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (Text == null)
				return null;

			var assembly = typeof(TranslateExtension).GetTypeInfo().Assembly;
			var assemblyName = assembly.GetName();
			var resourceManager = new ResourceManager($"{assemblyName.Name}.Ressources.Text.Localization_{AppSettings.lang}", assembly);

			string result = resourceManager.GetString(Text, CultureInfo.CurrentCulture);
			if (!string.IsNullOrWhiteSpace(StringFormat))
			{
				result = string.Format(StringFormat, result);
			}

			return result;

		}

		public static string GetLangRessource(string key)
		{
			var assembly = typeof(TranslateExtension).GetTypeInfo().Assembly;
			var assemblyName = assembly.GetName();
			var resourceManager = new ResourceManager($"{assemblyName.Name}.Localization_{AppSettings.lang}", assembly);
			return resourceManager.GetString(key, CultureInfo.CurrentCulture);
		}

		public static string GetJsonRessource(string key)
		{
			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(TranslateExtension)).Assembly;
			Stream stream = assembly.GetManifestResourceStream($"EorzeanFisher.Ressources.Json.{key}.json");
			string text = "";
			using (var reader = new StreamReader(stream))
			{
				text = reader.ReadToEnd();
			}
			return text;
		}
	}
}
