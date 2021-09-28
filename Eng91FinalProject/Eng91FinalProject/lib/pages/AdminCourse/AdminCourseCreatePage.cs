using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminCourseCreatePage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _courseName => _seleniumDriver.FindElement(By.Id("Name"));
        private IWebElement _assignTrainer => _seleniumDriver.FindElement(By.Id("TrainerId"));
        private IWebElement _assignStream => _seleniumDriver.FindElement(By.Id("StreamId"));
        private IWebElement _assignLocation => _seleniumDriver.FindElement(By.Id("Location"));
        private IWebElement _assignCourseLength => _seleniumDriver.FindElement(By.Id("CourseLengthInWeeks"));
        private IWebElement _assignCourseStart => _seleniumDriver.FindElement(By.Id("CourseStart"));
        private IWebElement _createButton => _seleniumDriver.FindElement(By.CssSelector(".btn-primary"));
        public AdminCourseCreatePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void InputCourseName(string course) => _courseName.SendKeys(course);
        public string GetTrainerName() => _assignTrainer.Text;
        public string GetStreamName() => _assignStream.Text;
        public string GetLocation() => _assignLocation.Text;
        public void InputCourseLength(string length) => _assignCourseLength.SendKeys(length);
        public void InputStartDate(string date) => _assignCourseStart.SendKeys(date);
        public void ClickCreateButton() => _createButton.Click();
    }
}
