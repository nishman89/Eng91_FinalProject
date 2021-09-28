using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eng91FinalProject.utils;

namespace Eng91FinalProject.lib.pages
{
    public class LoginPage
    {
        #region Properties
        private IWebDriver _seleniumDriver;

        //Set the Homepage URL (localhost)
        private string _homePageUrl = AppConfigReader.BaseURL;

        //Create a private property that models the sign in link
        private IWebElement _emailBox => _seleniumDriver.FindElement(By.Id("Email"));
        private IWebElement _passwordBox => _seleniumDriver.FindElement(By.Id("Password"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.LinkText("Login"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector(".validation-summary-errors"));
        #endregion

        public void Login() => _loginButton.Click();
        public void InputEmail(string email) => _emailBox.SendKeys(email);
        public void InputPassword(string password) => _emailBox.SendKeys(password);

        public void InputLoginCredentials(Credentials credentials)
        {
            _emailBox.SendKeys(credentials.Email);
            _passwordBox.SendKeys(credentials.Password);
        }

        public string GetErrorMessage() => _errorMessage.Text;

    }
}
