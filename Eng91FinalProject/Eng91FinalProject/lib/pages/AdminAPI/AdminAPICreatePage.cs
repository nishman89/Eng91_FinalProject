using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Eng91FinalProject.utils;

namespace Eng91FinalProject.lib.pages
{
    public class AdminAPICreatePage
    {
        private IWebDriver _seleniumDriver;
        private string _adminAPICreatePageUrl = AppConfigReader.AdminAPICreateURL;

        private IWebElement _referenceNameField => _seleniumDriver.FindElement(By.Id("ReferenceName"));
        private IWebElement _calendarField => _seleniumDriver.FindElement(By.Id("APIKeyExpiresOn"));
        private IWebElement _clearButton => _seleniumDriver.FindElement(By.Id("clearExpiresOn"));
        private IWebElement _requestLimitField => _seleniumDriver.FindElement(By.Id("RequestLimit"));
        private IWebElement _disabledCheckBox => _seleniumDriver.FindElement(By.Id("IsDisabled"));
        private IWebElement _saveButton => _seleniumDriver.FindElement(By.LinkText("Save"));

        public AdminAPICreatePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void InputReferenceName(string name) => _referenceNameField.SendKeys(name);
        public void InputExpirationDate(string date) => _calendarField.SendKeys(date);
        public void ClickClearButton() => _clearButton.Click();
        public void InputRequestLimit(string limit) => _requestLimitField.SendKeys(limit);
        public void CheckDisabledBox() => _disabledCheckBox.Click();
        public void ClickSaveButton() => _saveButton.Click();
    }
}
