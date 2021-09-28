using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Eng91FinalProject.utils;

namespace Eng91FinalProject.lib.pages
{
    public class TraineeProfilePage
    {
        private IWebDriver _seleniumDriver;
        private string _myProfilePageUrl = AppConfigReader.MyProfileURL;

        private IWebElement _editButton => _seleniumDriver.FindElement(By.LinkText("Edit"));
        private IWebElement _spartaGlobal => _seleniumDriver.FindElement(By.ClassName("navbar-brand pt-0 pb-0"));
        private IWebElement _homeButton => _seleniumDriver.FindElement(By.LinkText("Home"));
        private IWebElement _profilesButton => _seleniumDriver.FindElement(By.LinkText("Profiles"));
        private IWebElement _trackerButton => _seleniumDriver.FindElement(By.LinkText("Tracker"));
        private IWebElement _logoutButton => _seleniumDriver.FindElement(By.LinkText("Logout"));

        public TraineeProfilePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickEditButton() => _editButton.Click();
        public void ClickSpartaGlobalButton() => _spartaGlobal.Click();
        public void ClickHomeButton() => _homeButton.Click();
        public void ClickProfilesButton() => _profilesButton.Click();
        public void ClickTrackerButton() => _trackerButton.Click();
        public void ClickLogoutButton() => _logoutButton.Click();
    }
}
