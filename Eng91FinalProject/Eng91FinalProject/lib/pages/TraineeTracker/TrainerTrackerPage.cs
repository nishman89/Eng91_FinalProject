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
    public class TrainerTrackerPage
    {
        public TrainerTrackerPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Properties

        private IWebDriver _seleniumDriver;

        private IWebElement _traineeTrackerLink => _seleniumDriver.FindElement(By.LinkText("Trainee Tracker"));
        private IWebElement _deleteButton_BenHoward_Engineering79 => _seleniumDriver.FindElement(By.CssSelector("[href *= '/TraineeTracker/Delete/1']"));
        private IWebElement _editButton_BenHoward_Engineering79 => _seleniumDriver.FindElement(By.CssSelector("[href *= '/TraineeTracker/TrainerEdit/1']"));
        private IWebElement _commentBox => _seleniumDriver.FindElement(By.Id("comment"));
        private IWebElement _techGrades => _seleniumDriver.FindElement(By.Name("TrainerTechnicalGrade"));
        private IWebElement _consultGrades => _seleniumDriver.FindElement(By.Name("consuTrainerConsultantGradeltgrades"));
        private IWebElement _overallGrades => _seleniumDriver.FindElement(By.Name("OverallGrade"));
        private SelectElement _techGradeSelected => new SelectElement(_techGrades);
        private SelectElement _consultGradeSelected => new SelectElement(_consultGrades);
        private SelectElement _overallGradeSelected => new SelectElement(_overallGrades);
        private IWebElement _saveChangesButton => _seleniumDriver.FindElement(By.Id("create-button"));

        #endregion
        public void ClickCreateNewTracker() => _deleteButton_BenHoward_Engineering79.Click();
        public void ClickEditButton() => _editButton_BenHoward_Engineering79.Click();
        public void ManageComment(string message) => _commentBox.SendKeys(message);
        public void TraineeTrackerButton() => _traineeTrackerLink.Click();

        public void MaxTechGradeByValue()
        {
            _techGradeSelected.SelectByValue("A+");
            _consultGradeSelected.SelectByValue("A+");
            _overallGradeSelected.SelectByValue("A+");
        }
        public void MaxTechGradeByText()
        {
            _techGradeSelected.SelectByValue("A+");
            _consultGradeSelected.SelectByValue("A+");
            _overallGradeSelected.SelectByText("A+");
        }

        public void SaveChanges() => _saveChangesButton.Click();


    }
}
