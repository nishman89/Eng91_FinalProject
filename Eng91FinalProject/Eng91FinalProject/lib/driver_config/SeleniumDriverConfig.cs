using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Eng91FinalProject.lib.driver_config
{
    public class SeleniumDriverConfig<T> where T : IWebDriver, new()
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(int pageLoadInSecs, int implicitWaitInSec)
        {
            Driver = new T();
            DriverSetUp(pageLoadInSecs, implicitWaitInSec);
        }

        public void DriverSetUp(int pageLoadInSecs, int implicitWaitInSec)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSec);
        }

        public void SetHeadlessChromeBrowser()
        {
            Driver = new T();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
        }
    }
}
