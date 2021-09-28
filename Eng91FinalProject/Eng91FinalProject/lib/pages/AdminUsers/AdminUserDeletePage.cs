using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Eng91FinalProject.lib.pages
{
    public class AdminUserDeletePage
    {

        private IWebDriver _seleniumDriver;
        #region Properties
        private IWebElement _deleteButton => _seleniumDriver.FindElement(By.ClassName("btn btn-danger"));
        private IWebElement _backToListButton => _seleniumDriver.FindElement(By.LinkText("Back to List"));

        private IReadOnlyCollection<IWebElement> _detailsFields => _seleniumDriver.FindElements(By.ClassName("col-sm-10"));
        private IReadOnlyCollection<IWebElement> _fieldNames => _seleniumDriver.FindElements(By.ClassName("col-sm-2"));
        #endregion

        #region Methods
        public void ClickBackToListButton() => _backToListButton.Click();
        public void ClickDeleteButton() => _deleteButton.Click();
        #endregion
    }
}
