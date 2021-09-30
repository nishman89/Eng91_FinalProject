using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Eng91FinalProject.utils;

namespace Eng91FinalProject.lib.pages
{
    public class AdminAPIPage
    {
        private IWebDriver _seleniumDriver;
        private string _adminAPIPageUrl = AppConfigReader.AdminAPIURL;

        private IWebElement _enterAPIHeader => _seleniumDriver.FindElement(By.Id("Search"));
        private IWebElement _searchButton => _seleniumDriver.FindElement(By.CssSelector(".row:nth-child(1) > .btn"));
        private IWebElement _newButton => _seleniumDriver.FindElement(By.CssSelector(".fa-plus-circle"));
        private IWebElement _deleteButton(string api) => _seleniumDriver.FindElement(By.CssSelector($"#{api} [data-action=\"Delete\"]"));
        private IWebElement _okButton => _seleniumDriver.FindElement(By.Id("WarningModalOk"));
        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.CssSelector(".btn-primary:nth-child(1)"));
        private IWebElement _disableButton(string api) => _seleniumDriver.FindElement(By.CssSelector($"#{api} [data-action=\"Disable\"]"));
        private IWebElement _enableButton(string api) => _seleniumDriver.FindElement(By.CssSelector(".btn-success"));
        private IWebElement _resetButton(string api) => _seleniumDriver.FindElement(By.CssSelector($"#{api} [data-action=\"Reset\"]"));
        private IWebElement _editButton(string api) => _seleniumDriver.FindElement(By.CssSelector($"#{api} .btn-primary"));
        private IWebElement _expandAPI(string api) => _seleniumDriver.FindElement(By.CssSelector($"#{api} .btn-link"));
        private IWebElement _apiInformation(string api) => _seleniumDriver.FindElement(By.Id($"{api}_Collapse"));

        public AdminAPIPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void InputHeader(string header) => _enterAPIHeader.SendKeys(header);
        public void ClickSearchButton() => _searchButton.Click();
        public void ClickNewButton() => _newButton.Click();
        public void ClickDeleteButton(string api) => _deleteButton(api).Click();
        public void ClickOkButton() => _okButton.Click();
        public void ClickCancelButton() => _cancelButton.Click();
        public void ClickDisableButton(string api) => _disableButton(api).Click();
        public string IsDisabled(string api) => _enableButton(api).Text;
        public string IsEnabled(string api) => _disableButton(api).Text;
        public void ClickEnableButton(string api) => _enableButton(api).Click();
        public void ClickResetButton(string api) => _resetButton(api).Click();
        public void ClickEditButton(string api) => _editButton(api).Click();
        public void ExpandAPI(string api) => _expandAPI(api).Click();
        public string APIInformation(string api) => _apiInformation(api).Text;
        public bool DisplayAPIInformation(string api) => _apiInformation(api).GetAttribute("class").Contains("collapse show");
    }
}
