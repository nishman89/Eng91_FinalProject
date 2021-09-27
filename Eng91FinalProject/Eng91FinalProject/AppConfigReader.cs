using System;
using System.Configuration;

namespace Eng91FinalProject
{
    public static class AppConfigReader
    {
        public static readonly string BaseURL = ConfigurationManager.AppSettings["base_url"];
    }
}
