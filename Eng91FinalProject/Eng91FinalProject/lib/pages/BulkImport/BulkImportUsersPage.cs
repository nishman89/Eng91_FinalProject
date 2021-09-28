using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages
{
    public class BulkImportUsersPage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _findChooseFileButton => _seleniumDriver.FindElement(By.Id("File"));
        private IWebElement _findSaveButton => _seleniumDriver.FindElement(By.Id("saveButton"));

        #endregion




        public void ClickCreateNewTracker() => _findChooseFileButton.Click();
        public void ClickEditButton() => _findSaveButton.Click();
    }
}
