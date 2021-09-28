using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminStreamCreatePage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _findDataField => _seleniumDriver.FindElement(By.Id("Name"));
        private IWebElement _findSaveBttn => _seleniumDriver.FindElement(By.CssSelector("[class='btn btn-primary m-2']"));


        #endregion

        public AdminStreamCreatePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void GiveDataToNameField(string data) => _findDataField.SendKeys(data);
        public void ClickSaveBttn() => _findSaveBttn.Click();





    }
}
