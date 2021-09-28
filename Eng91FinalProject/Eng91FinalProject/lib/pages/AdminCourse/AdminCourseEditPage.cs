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
        private IWebElement _saveButton => _seleniumDriver.FindElement(By.CssSelector(".btn-primary"));
        public AdminCourseEditPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void EnterCourseName(string courseName) => _courseName.SendKeys(courseName);
        public void EnterTrainerName(string trainerName) => _trainerName.SendKeys(trainerName);
        public void EnterStreamName(string streamName) => _streamName.SendKeys(streamName);
        public void EnterLocationName(string locationName) => _locationName.SendKeys(locationName);
        public void SaveButton() => _saveButton.Click();
        
    }
}
