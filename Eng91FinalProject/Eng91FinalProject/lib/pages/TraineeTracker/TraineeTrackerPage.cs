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
        public TraineeTrackerPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        #region Properties

        private IWebDriver _seleniumDriver;
        private IWebElement _newTrackerButton => _seleniumDriver.FindElement(By.Id("CreateNewTrackerButton"));
        private IWebElement _trackerButton => _seleniumDriver.FindElement(By.LinkText("Tracker"));
        private IWebElement _selfCheckFeedback_Week => _seleniumDriver.FindElement(By.Id("weekSelector"));
        private IWebElement _editTrackerButton => _seleniumDriver.FindElement(By.Id("EditTracker"));
        private IWebElement _editButton_BenHoward_Engineering79 => _seleniumDriver.FindElement(By.CssSelector("[href *= '/TraineeTracker/TrainerEdit/20']"));
        private IWebElement _stopBox => _seleniumDriver.FindElement(By.Id("stop"));
        private IWebElement _startBox => _seleniumDriver.FindElement(By.Id("start"));
        private IWebElement _continueBox => _seleniumDriver.FindElement(By.Id("continue"));
        private IWebElement _saveChangesButton => _seleniumDriver.FindElement(By.XPath("//input[@value='Save']"));
        private IWebElement _aSkill => _seleniumDriver.FindElement(By.Id("Atech"));
        private IWebElement _bSkill => _seleniumDriver.FindElement(By.Id("Btech"));
        private IWebElement _cSkill => _seleniumDriver.FindElement(By.Id("Ctech"));
        private IWebElement _dSkill => _seleniumDriver.FindElement(By.Id("Dtech"));
        private IWebElement _aConsultant => _seleniumDriver.FindElement(By.Id("Aconsultant"));
        private IWebElement _bConsultant => _seleniumDriver.FindElement(By.Id("Bconsultant"));
        private IWebElement _cConsultant => _seleniumDriver.FindElement(By.Id("Cconsultant"));
        private IWebElement _dConsultant => _seleniumDriver.FindElement(By.Id("Dconsultant"));

        #endregion
        public void SaveChanges() => _saveChangesButton.Click();
        public void ClickEditButton() => _editButton_BenHoward_Engineering79.Click();
        public void PressEditTrackerButton() => _editTrackerButton.Click();
        public void PressTrackerButton() => _trackerButton.Click();
        public void Select_Skill_A() => _aSkill.Click();
        public void Select_Skill_B() => _bSkill.Click();
        public void Select_Skill_C() => _cSkill.Click();
        public void Select_Skill_D() => _dSkill.Click();
        public void Select_Consultant_A() => _aConsultant.Click();
        public void Select_Consultant_B() => _bConsultant.Click();
        public void Select_Consultant_C() => _cConsultant.Click();
        public void Select_Consultant_D() => _dConsultant.Click();
        public void SetSweek(int weekNumber) => _selfCheckFeedback_Week.SendKeys(weekNumber.ToString());
        public void ManageStop(string message)
        {
            _stopBox.Clear();
            _stopBox.SendKeys(message);
        }
        public void ManageStart(string message)
        {
            _startBox.Clear();
            _startBox.SendKeys(message);
        }
        public void ManageContinue(string message)
        {
            _continueBox.Clear();
            _continueBox.SendKeys(message);
        }
        public bool CanICreateNewTracker()
        {
            try
            {
                _seleniumDriver.FindElement(By.Id("CreateNewTrackerButton"));
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }
        public bool IsInEditPage()
        {
            try
            {
                _seleniumDriver.FindElement(By.XPath("//h1[contains(.,'Tracker - Week 1')]"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
