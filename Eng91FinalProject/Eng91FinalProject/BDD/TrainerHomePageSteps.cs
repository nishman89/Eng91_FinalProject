using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using System.Threading;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TrainerHomePage")]
    public class TrainerHomePageSteps :SharedLoginSteps
    {
        
        
        [When(@"I click EXPAND ALL")]
        public void WhenIClickEXPANDALL()
        {
            Website.HomePage.ClickExpandAndHideAllButton();
        }

        [When(@"I click a trainee")]
        public void WhenIClickATrainee()
        {
            Website.HomePage.ClickTrainee1ResultsContainer();
        }
        
        [Then(@"all test results are shown")]
        public void ThenAllTestResultsAreShown()
        {
            Thread.Sleep(5000);
            Assert.That(Website.HomePage.IsExpandedAll, Is.EqualTo(true));
            
        }  

        [Then(@"That trainee's test results are shown")]
        public void ThenThatTraineeSTestResultsAreShown()
        {
            Thread.Sleep(5000);
            Assert.True(Website.HomePage.IsExpandedBen());
        }


        [When(@"I click PROGRESS TRACKER")]
        public void WhenIClickPROGRESSTRACKER()
        {
            Website.HomePage.ClickProgressTrackerButton();
        }

        [Then(@"I am taken to the Progress Tracker page")]
        public void WhenIAmTakenToTheProgressTrackerPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Progress"));
        }

        [When(@"I Click Course Attendance")]
        public void WhenIClickCourseAttendance()
        {
            Website.HomePage.ClickCourseAttendanceButton();
        }

        [Then(@"I am taken to the Course Attendance page")]
        public void ThenIAmTakenToTheCourseAttendancePage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("AttendanceIndex"));
        }

        [Then(@"Correct stream is shown")]
        public void ThenCorrectStreamIsShown()
        {
            Assert.That(Website.CourseAttendancePage.GetStreamTitle().Contains("Engineering 79 Attendance"), Is.True);
        }

        [Then(@"All Course students are shown")]
        public void ThenAllCourseStudentsAreShown()
        {
            Assert.That(Website.CourseAttendancePage.StudentCount(), Is.EqualTo(12));
        }

    }
}
