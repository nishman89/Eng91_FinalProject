﻿using System;
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

        private IWebElement _savedTechnical => _seleniumDriver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(6)"));
        private IWebElement _savedConsultancy => _seleniumDriver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(7)"));
        private IWebElement _savedOverall => _seleniumDriver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(8)"));

        #endregion
        public void ClickCreateNewTracker() => _deleteButton_BenHoward_Engineering79.Click();
        public void ClickEditButton_BenHoward() => _editButton_BenHoward_Engineering79.Click();
        public void ManageComment(string message)
        {
            _commentBox.Clear();
            _commentBox.SendKeys(message);
        }
        public void TraineeTrackerButton() => _traineeTrackerLink.Click();

        public void MaxTechGradeByValue()
        {
            _techGradeSelected.SelectByValue("A+");
            _consultGradeSelected.SelectByValue("A+");
            _overallGradeSelected.SelectByValue("A+");
        }
        public void MaxTechGradeByText()
        {
            _techGradeSelected.SelectByText("A+");
            _consultGradeSelected.SelectByText("A+");
            _overallGradeSelected.SelectByText("A+");
        }

        public void SaveChanges() => _saveChangesButton.Click();

        public bool IsInTrackerPage()
        {
            try
            {
                _seleniumDriver.FindElement(By.CssSelector("th:nth-child(1)"));
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

        public (string, string, string) ReturnGrades() => (_savedTechnical.Text, _savedConsultancy.Text, _savedOverall.Text);

    }
}
