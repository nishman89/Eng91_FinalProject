using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminCoursesPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _createNewCourse => _seleniumDriver.FindElement(By.CssSelector(".col-sm-12"));
        private IWebElement _searchButton => _seleniumDriver.FindElement(By.CssSelector(".form-group .btn"));
        private IWebElement _searchBar => _seleniumDriver.FindElement(By.Name("searchString"));
        private IWebElement _result => _seleniumDriver.FindElement(By.Name("card-header"));
        public AdminCoursesPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void CreateNewCourse() => _createNewCourse.Click();
        public string FormatSearch(string Course) => Course.Replace(" ", "-");
        public void EditCourse(string course) => _seleniumDriver.FindElement(By.CssSelector($"#{course} .btn-primary")).Click();
        public void DeleteCourse(string course) => _seleniumDriver.FindElement(By.CssSelector($"#{course} .btn-danger")).Click();
        public void ClickSearch() => _searchButton.Click();
        public void Search(string course) => _searchBar.SendKeys(course);
        public string SearchResult(string course) => _seleniumDriver.FindElement(By.CssSelector($"#{course} .btn-link")).Text;
    }
}
