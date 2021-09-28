using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminUserCreatePage
    {
        public enum TitleEnum
        {
            Mr,
            Mrs,
            Miss,
            Dr,
            Mx
        }
        public enum RoleEnum
        {
            Trainee,
            Trainer
        }
        public enum StreamEnum
        {
            CSharpDeveloper,
            CSharpSDET,
            DevOps,
            BusinessAnalyst,
            JavaDeveloper
        }
        public enum CourseEnum
        {
            Engineering79,
            Engineering81
        }
        private IWebDriver _seleniumDriver;
        private IWebElement _titleSelectDropdown => _seleniumDriver.FindElement(By.CssSelector(".row:nth-child(4) .filter-option-inner-inner"));
        private IWebElement _titleSelectTitle(TitleEnum titleEnum) => _seleniumDriver.FindElement(By.Id($"bs-select-1-{(int)titleEnum + 1}"));
        private IWebElement _roleSelectDropdown => _seleniumDriver.FindElement(By.CssSelector(".row:nth-child(6) .filter-option-inner-inner"));
        private IWebElement _roleSelectRole(RoleEnum roleEnum) => _seleniumDriver.FindElement(By.Id($"bs-select-2-{(int)roleEnum + 1}"));
        private IWebElement _assignFirstName => _seleniumDriver.FindElement(By.Id("FirstName"));
        private IWebElement _assignLastName => _seleniumDriver.FindElement(By.Id("LastName"));
        private IWebElement _assignEmail => _seleniumDriver.FindElement(By.Id("Email"));
        private IWebElement _assignPassword => _seleniumDriver.FindElement(By.Id("Password"));
        private IWebElement _assignLocation => _seleniumDriver.FindElement(By.Id("Location"));
        private IWebElement _streamSelectDropdown => _seleniumDriver.FindElement(By.CssSelector(".row:nth-child(20) .filter-option-inner-inner"));
        private IWebElement _streamSelectStream(StreamEnum streamEnum) => _seleniumDriver.FindElement(By.Id($"bs-select-4-{(int)streamEnum}"));
        private IWebElement _courseSelectDropdown => _seleniumDriver.FindElement(By.CssSelector(".row:nth-child(22) .filter-option-inner-inner"));
        private IWebElement _courseSelectCourse(CourseEnum courseEnum) => _seleniumDriver.FindElement(By.Id($"bs-select-5-{(int)courseEnum}"));
        private IWebElement _saveButton => _seleniumDriver.FindElement(By.CssSelector(".btn-primary"));

        public AdminUserCreatePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickTitleDropdown() => _titleSelectDropdown.Click();
        public void SelectTitleFromDropdown(TitleEnum titleEnum) => _titleSelectTitle(titleEnum).Click();
        public void ClickRoleDropdown() => _titleSelectDropdown.Click();
        public void SelectRoleFromDropdown(RoleEnum roleEnum) => _roleSelectRole(roleEnum).Click();
        public void InputFirstName(string firstname) => _assignFirstName.SendKeys(firstname);
        public void InputLastName(string lastname) => _assignLastName.SendKeys(lastname);
        public void InputEmail(string email) => _assignEmail.SendKeys(email);
        public void InputPassword(string password) => _assignPassword.SendKeys(password);
        public void InputLocation(string location) => _assignLocation.SendKeys(location);
        public void ClickStreamDropdown() => _streamSelectDropdown.Click();
        public void SelectStreamFromDropdown(StreamEnum streamEnum) => _streamSelectStream(streamEnum).Click();
        public void ClickCourseDropdown() => _courseSelectDropdown.Click();
        public void SelectCourseFromDropdown(CourseEnum courseEnum) => _courseSelectCourse(courseEnum).Click();
        public void ClickSaveButton() => _saveButton.Click();

    }
}
