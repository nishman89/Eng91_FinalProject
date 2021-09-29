using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages.Navbar
{
    public class SharedNavbar
    {
        private IWebDriver _seleniumDriver { get; set; }
        private IWebElement _logoutButton => _seleniumDriver.FindElement(By.LinkText("Logout"));
        private IWebElement _homeButton => _seleniumDriver.FindElement(By.LinkText("Home"));
        private IWebElement _spartaGlobal => _seleniumDriver.FindElement(By.CssSelector("img"));

        public SharedNavbar(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        
        public void ClickHomeButton() => _homeButton.Click();
        public void ClickLogoutButton() => _logoutButton.Click();
        public void ClickSpartaGlobalIcon() => _spartaGlobal.Click();
    }
}
