using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Eng91FinalProject.lib.pages
{
    public class TraineeTrackerPage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _findCreateNewTracker => _seleniumDriver.FindElement(By.Id("CreateNewTrackerButton"));
        private IWebElement _findEditButton => _seleniumDriver.FindElement(By.Id("EditTracker"));

        #endregion



        public void ClickCreateNewTracker() => _findCreateNewTracker.Click();
        public void ClickEditButton() => _findEditButton.Click();




    }
}
