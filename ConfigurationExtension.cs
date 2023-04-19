using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PatientRegistration.Helper;
using PatientRegistration.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientRegistration.Extensions
{
    public static class ConfigurationExtension
    {
        public static AppSettings LoadConfiguration(this IConfiguration config)
        {
            var file = System.IO.File.ReadAllText(Constants._configPath);
            PatientRegistration.Settings.AppSettings appSetting = JsonConvert.DeserializeObject<PatientRegistration.Settings.AppSettings>(file);
            return appSetting;
        }

        private static void getPropertiesAndValues(string json, ref IConfiguration ret)
        {

            JObject jObject = JObject.Parse(json);
            foreach (JProperty i in jObject.Properties())
            {
                var name = i.Name;
                var value = i.Value;

                if (!i.Value.HasValues)
                    ret[name] = value.ToString();

                Console.WriteLine();
                if (i.HasValues && i.Value.HasValues)
                    getPropertiesAndValues(i.First.ToString(), ref ret);
            }

        }
    }
}
