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
        private IWebElement _createNewCourse => _seleniumDriver.FindElement(By.CssSelector("[class='btn btn - primary col - sm - 12 mb - 4'"));
        private IWebElement _editCourse => _seleniumDriver.FindElement(By.CssSelector("[class='fas fa-edit pr-2'"));
        private IWebElement _deleteCourse => _seleniumDriver.FindElement(By.CssSelector("[class='float-right btn btn-danger ml-2']"));
        private IWebElement _searchButton => _seleniumDriver.FindElement(By.CssSelector("[class='btn btn - primary'"));
        private IWebElement _searchBar => _seleniumDriver.FindElement(By.Name("searchString"));
        public AdminCoursesPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void CreateNewCourse() => _createNewCourse.Click();
        public void EditCourse() => _editCourse.Click();
        public void DeleteCourse() => _deleteCourse.Click();
        public void SearchCourse() => _searchButton.Click();
        public void Search(string course) => _searchBar.SendKeys(course);
    }
}
