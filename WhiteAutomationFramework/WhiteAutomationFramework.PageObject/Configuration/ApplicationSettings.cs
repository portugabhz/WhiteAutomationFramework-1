using System.Collections.Specialized;
using System.Configuration;

namespace WhiteAutomationFramework.PageObject.Configuration
{
    public static class ApplicationSettings
    {
        public static string getApplicationTitle
        {
            get
            {
                var section = ConfigurationManager.GetSection("applicationTitle") as NameValueCollection;
                return section != null ? section["applicationTitle"] : null;
            }
        }

        private static string GetSettingValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        public static string GetApplicationPath()
        {
            return GetSettingValue("ApplicationPath");
        }
    }
}
