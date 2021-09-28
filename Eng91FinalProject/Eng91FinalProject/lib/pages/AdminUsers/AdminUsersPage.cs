using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminUsersPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _createNewUser => _seleniumDriver.FindElement(By.CssSelector(".col-sm-1"));
        private IWebElement _searchButton => _seleniumDriver.FindElement(By.CssSelector(".row:nth-child(1) > .btn"));
        private IWebElement _searchBar => _seleniumDriver.FindElement(By.Id("Search"));
        private IWebElement _editUser(string username) => _seleniumDriver.FindElement(By.CssSelector($"#{username} .btn-primary"));
        private IWebElement _lockUser(string username) => _seleniumDriver.FindElement(By.CssSelector($"#{username} .btn-warning"));
        private IWebElement _deleteUser(string username) => _seleniumDriver.FindElement(By.CssSelector($"#{username} .btn-danger"));

        public AdminUsersPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void CreateNewUser() => _createNewUser.Click();
        public void EditUser(string username) => _editUser(username).Click();
        public void LockUser(string username) => _lockUser(username).Click();
        public void DeleteCourse(string username) => _deleteUser(username).Click();
        public void SearchUser() => _searchButton.Click();
        public void Search(string username) => _searchBar.SendKeys(username);
    }
}
