using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Eng91FinalProject.utils;

namespace Eng91FinalProject.lib.pages
{
    public class AdminAPIPage
    {
        private IWebDriver _seleniumDriver;
        private string _adminAPIPageUrl = AppConfigReader.AdminAPIURL;

        private IWebElement _enterAPIHeader => _seleniumDriver.FindElement(By.Id("Search"));
        private IWebElement _searchButton => _seleniumDriver.FindElement(By.LinkText("Search"));
        private IWebElement _newButton => _seleniumDriver.FindElement(By.LinkText(" New "));

        public AdminAPIPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void InputHeader(string header) => _enterAPIHeader.SendKeys(header);
        public void ClickSearchButton() => _searchButton.Click();
        public void ClickNewButton() => _newButton.Click();
    }
}
