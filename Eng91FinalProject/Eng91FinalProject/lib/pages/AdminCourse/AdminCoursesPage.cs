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
        private IWebElement _searchButton => _seleniumDriver.FindElement(By.CssSelector(".form-group.btn"));
        private IWebElement _searchBar => _seleniumDriver.FindElement(By.Name("searchString"));
        private IWebElement _result => _seleniumDriver.FindElement(By.Name("card-header"));
        public AdminCoursesPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void CreateNewCourse() => _createNewCourse.Click();
        public void EditCourse(string courseNum) => _seleniumDriver.FindElement(By.CssSelector($"#Engineering-{courseNum}.btn-primary")).Click();
        public void DeleteCourse(string courseNum) => _seleniumDriver.FindElement(By.CssSelector($"#Engineering-{courseNum}.btn-danger")).Click();
        public void ClickSearch() => _searchButton.Click();
        public void Search(string course) => _searchBar.SendKeys(course);
        public string SearchResult() => _result.Text;
    }
}
