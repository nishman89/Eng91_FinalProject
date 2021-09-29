using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Tag = "AdminCourseCreate")]
    public class AdminCourseCreatePageSteps : SharedLoginSteps
    {
        [Given(@"I click Courses")]
        public void GivenIClickCourses()
        {
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
        }
        
        [When(@"I click New")]
        public void WhenIClickNew()
        {
            Website.AdminCoursesPage.CreateNewCourse();
        }
        
        [Then(@"I am taken to the Course create page")]
        public void ThenIAmTakenToTheCourseCreatePage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Create"));
        }
    }
}
