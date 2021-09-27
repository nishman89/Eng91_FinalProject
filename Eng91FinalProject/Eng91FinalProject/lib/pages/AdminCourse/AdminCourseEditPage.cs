using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminCourseEditPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _courseName => _seleniumDriver.FindElement(By.Id("Name"));
        private IWebElement _trainerName => _seleniumDriver.FindElement(By.Id("TrainerId"));
        private IWebElement _streamName => _seleniumDriver.FindElement(By.Id("StreamId"));
        private IWebElement _locationName => _seleniumDriver.FindElement(By.Id("Location"));
        private IWebElement _saveButton => _seleniumDriver.FindElement(By.CssSelector("[clas='btn btn-primary m-2']"));
        public AdminCourseEditPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void SaveButton() => _saveButton.Click();
    }
}
