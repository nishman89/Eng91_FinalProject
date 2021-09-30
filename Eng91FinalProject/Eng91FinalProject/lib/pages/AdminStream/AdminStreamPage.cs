using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng91FinalProject.lib.pages
{
    public class AdminStreamPage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _findSearchBar => _seleniumDriver.FindElement(By.Id("Search"));
        private IWebElement _findSearchButton => _seleniumDriver.FindElement(By.CssSelector(".form-group .btn"));
        private IWebElement _findCreateNew => _seleniumDriver.FindElement(By.CssSelector(".col-sm-1"));
        private IWebElement _findEditButton => _seleniumDriver.FindElement(By.CssSelector("[href*='/Stream/Record/1']"));
        private IWebElement _findDisableButton => _seleniumDriver.FindElement(By.ClassName("float-right btn btn-danger ml-2"));
        private IWebElement _findCancelBttn_OnDisable => _seleniumDriver.FindElement(By.CssSelector("[class='btn btn-primary']"));
        private IWebElement _findOKBttn_OnDisable => _seleniumDriver.FindElement(By.Id("WarningModalOk"));
        private IWebElement _result => _seleniumDriver.FindElement(By.Name("card-header"));
        private IWebElement _findDeleteButton => _seleniumDriver.FindElement(By.CssSelector("[href*='/Stream/Delete/1']"));
        #endregion
        public AdminStreamPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        public void InsertDataIntoSearchBar(string data) => _findSearchBar.SendKeys(data);
        public void ClickSearchBttn() => _findSearchButton.Click();
        public void ClickCreateNew() => _findCreateNew.Click();
        public void EditStream(string stream) => _seleniumDriver.FindElement(By.CssSelector($"#{stream} .btn-primary")).Click();
        public void DeleteStream(string stream) => _seleniumDriver.FindElement(By.CssSelector($"#{stream} .btn-danger")).Click();
        public void ClickDisableBttn() => _findDisableButton.Click();
        public void ClickCancelBttnOnDisable() => _findCancelBttn_OnDisable.Click();
        public void ClickOkBttnOnDisable() => _findOKBttn_OnDisable.Click();
        public void ClickDeleteBttn() => _findDeleteButton.Click();
        public string SearchResult(string stream) => _seleniumDriver.FindElement(By.CssSelector($"#{stream} .btn-link")).Text;
        public string FormatStream(string stream) => stream.Replace(" ", "-").Replace("#", "_");

    }
}
