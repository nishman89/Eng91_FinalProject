using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages
{
    public class AdminStreamEditPage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _findEditBar => _seleniumDriver.FindElement(By.Id("Name"));
        private IWebElement _findSaveBtnn => _seleniumDriver.FindElement(By.CssSelector("[class='btn btn-primary m-2']"));

        #endregion

        public AdminStreamEditPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        public void ClickDeleteBar(string data) => _findEditBar.SendKeys(data);
        public void ClickBackToList() => _findSaveBtnn.Click();
    }
}
