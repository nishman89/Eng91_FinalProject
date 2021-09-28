using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages.Navbar
{
    public class TraineeNavbar
    {
        private IWebDriver _seleniumDriver { get; set; }
        
        private IWebElement _trackerButton => _seleniumDriver.FindElement(By.LinkText("Tracker"));
        private IWebElement _traineeProfile => _seleniumDriver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[1]/li[1]/a"));
        



        public TraineeNavbar(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        //POM Methods
        public void ClickTrackerButton() => _trackerButton.Click();
        public void ClickTraineeProfile() => _traineeProfile.Click();
        
    }
}
