using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminStreamDeletePage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _findDeleteBar => _seleniumDriver.FindElement(By.CssSelector("[class='btn btn - danger']"));
        private IWebElement _findBackToListBttn => _seleniumDriver.FindElement(By.CssSelector("[href='/Stream']"));
        

        #endregion

        public void ClickDeleteBar() => _findDeleteBar.Click();
        public void ClickBackToList() => _findBackToListBttn.Click();

    }
}
