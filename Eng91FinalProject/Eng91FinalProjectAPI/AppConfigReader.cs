using System.Configuration; //Allows us to access the app.config file

namespace Eng91FinalProjectAPI
{
    public class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly string ApiToken = ConfigurationManager.AppSettings["api_token"];
        public static readonly string DisabledAPIKey = ConfigurationManager.AppSettings["disabled_api_key"];
        public static readonly string DisabledAPIToken = ConfigurationManager.AppSettings["disabled_api_token"];

    }
}
