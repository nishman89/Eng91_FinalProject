using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Eng91FinalProject.lib.pages
{
    public class TraineeTrackerPage
    {
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _selfCheckFeedback_Week => _seleniumDriver.FindElement(By.Id("weekSelector"));
        private IWebElement _editButton_BenHoward_Engineering79 => _seleniumDriver.FindElement(By.CssSelector("[href *= '/TraineeTracker/TrainerEdit/20']"));
        private IWebElement _stopBox => _seleniumDriver.FindElement(By.Id("stop"));
        private IWebElement _startBox => _seleniumDriver.FindElement(By.Id("start"));
        private IWebElement _continueBox => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _saveChangesButton => _seleniumDriver.FindElement(By.XPath("xpath=//input[@value='Save']"));
        private IWebElement _aSkill => _seleniumDriver.FindElement(By.Id("Atech"));
        private IWebElement _bSkill => _seleniumDriver.FindElement(By.Id("Btech"));
        private IWebElement _cSkill => _seleniumDriver.FindElement(By.Id("Ctech"));
        private IWebElement _dSkill => _seleniumDriver.FindElement(By.Id("Dtech"));
        private IWebElement _aConsultant => _seleniumDriver.FindElement(By.Id("Aconsultant"));
        private IWebElement _bConsultant => _seleniumDriver.FindElement(By.Id("Bconsultant"));
        private IWebElement _cConsultant => _seleniumDriver.FindElement(By.Id("Cconsultant"));
        private IWebElement _dConsultant => _seleniumDriver.FindElement(By.Id("Dconsultant"));

        #endregion
        public void ManageStop(string message) => _stopBox.SendKeys(message);
        public void ManageStart(string message) => _stopBox.SendKeys(message);
        public void ManageContinue(string message) => _stopBox.SendKeys(message);
        public void SaveChanges() => _saveChangesButton.Click();
        public void ClickEditButton() => _editButton_BenHoward_Engineering79.Click();

        public void Select_Skill_A() => _aSkill.Click();
        public void Select_Skill_B() => _bSkill.Click();
        public void Select_Skill_C() => _cSkill.Click();
        public void Select_Skill_D() => _dSkill.Click();
        public void Select_Consultant_A() => _aConsultant.Click();
        public void Select_Consultant_B() => _bConsultant.Click();
        public void Select_Consultant_C() => _cConsultant.Click();
        public void Select_Consultant_D() => _dConsultant.Click();
        public void SetSweek(int weekNumber) => _selfCheckFeedback_Week.SendKeys(weekNumber.ToString());


    }
}
