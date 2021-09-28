using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminCourseDeletePage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _deleteButton => _seleniumDriver.FindElement(By.CssSelector(".btn"));
        private IWebElement _backToList => _seleniumDriver.FindElement(By.LinkText("Back to List"));
        public AdminCourseDeletePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void DeleteButton() => _deleteButton.Click();
        public void BackToList() => _backToList.Click();
    }
}
