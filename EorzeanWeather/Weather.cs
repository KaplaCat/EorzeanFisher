using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace EorzeanWeather
{
    public class Weather
    {
        const string TerritoryJson = "EorzeanWeather.data.TerritoryWeather.json";
        const string WeatherJson = "EorzeanWeather.data.Weather.json";
        const string WeatherRateJson = "EorzeanWeather.data.WeatherRate.json";

        public static string Forecast(string placename, string lang = "fr", bool strict = true)
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            double timestamp = t.TotalSeconds;
            string weatherRate = getWeatherRate(placename, strict);
            int target;
            string result = string.Empty;
            
            try
            {            
                target = computeForecastTarget(timestamp);
                result = generateResult(target, weatherRate, lang); 
            }catch(Exception)
            {
            }

            return result;
        }

        public static List<string> Forecast2Hours(string placename, string lang = "fr", bool strict = true)
        {
            List<string> result = new List<string>();
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;

            string weatherRate = getWeatherRate(placename, strict);

            int target = computeForecastTarget(secondsSinceEpoch);
            result.Add(generateResult(target, weatherRate, lang));

            t = DateTime.UtcNow.AddMinutes(30) - new DateTime(1970, 1, 1);
            secondsSinceEpoch = (int)t.TotalSeconds;
            target = computeForecastTarget(secondsSinceEpoch);
            result.Add(generateResult(target, weatherRate, lang));

            t = DateTime.UtcNow.AddMinutes(60) - new DateTime(1970, 1, 1);
            secondsSinceEpoch = (int)t.TotalSeconds;
            target = computeForecastTarget(secondsSinceEpoch);
            result.Add(generateResult(target, weatherRate, lang));

            t = DateTime.UtcNow.AddMinutes(90) - new DateTime(1970, 1, 1);
            secondsSinceEpoch = (int)t.TotalSeconds;
            target = computeForecastTarget(secondsSinceEpoch);
            result.Add(generateResult(target, weatherRate, lang));

            t = DateTime.UtcNow.AddMinutes(120) - new DateTime(1970, 1, 1);
            secondsSinceEpoch = (int)t.TotalSeconds;
            target = computeForecastTarget(secondsSinceEpoch);
            result.Add(generateResult(target, weatherRate, lang));

            return result;
        }
        

        static string getWeatherRate(string placeName, bool strict)
        {
            string weatherRate = string.Empty;
            try
            {
                weatherRate = getFileFromRessource(TerritoryJson).GetValue(placeName).ToString();
            }
            catch (Exception)
            {
            }
            return weatherRate;
        }

        static string generateResult(int target, string weatherRate, string lang)
        {
            string result = string.Empty;

            var rate = getFileFromRessource(WeatherRateJson).GetValue(weatherRate.ToString());
            int i = 0;
            foreach(var o in rate)
            {
                int correct = int.Parse(rate[i].ToString());
                if (target < correct)
                {
                    var obj = getFileFromRessource(WeatherJson).GetValue(rate[i+1].ToString());
                    result = ((JObject)obj).GetValue(lang).ToString();
                    return result;
                }
                i+=2;
            }

            return result;
        }

        static int computeForecastTarget(double lt)
        {
            var bell = lt / 175;
            var increment = (Int32)(bell + 8 - (bell % 8)) % 24;
            var total_days = (Int32)(lt / 4200);
            var calc_base = total_days * 0x64 + increment;
            var step1 = (Int32)(calc_base << 0xB) ^ calc_base;
            var step2 = (step1 >> 8) ^ step1;
            return (int)(step2 % 100);
        }

        static JObject getFileFromRessource(string filePath)
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(Weather)).Assembly;
            var stream = assembly.GetManifestResourceStream(filePath);

            var resourceContent = string.Empty;
            using (var reader = new StreamReader(stream))
            {
                resourceContent = reader.ReadToEnd();
            }
            JObject json = JObject.Parse(resourceContent);
            return json;
        }
    }
}
