using System;
using System.Configuration;

namespace Eng91FinalProject
{
    public static class AppConfigReader
    {
        public static readonly string BaseURL = ConfigurationManager.AppSettings["base_url"];
        public static readonly string MyProfileURL = ConfigurationManager.AppSettings["myprofile_url"];
        public static readonly string AdminAPIURL = ConfigurationManager.AppSettings["adminapi_url"];
        public static readonly string AdminAPICreateURL = ConfigurationManager.AppSettings["adminapicreate_url"];
        public static readonly string AdminAPIEditURL = ConfigurationManager.AppSettings["adminapiedit_url"];
    }
}
