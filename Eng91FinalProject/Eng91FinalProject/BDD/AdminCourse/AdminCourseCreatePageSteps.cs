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
            Website.TrainerNavbar.ClickAdminDropdownButton();
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
        }

        [When(@"I click New")]
        public void WhenIClickNew()
        {
            Website.AdminCoursesPage.CreateNewCourse();
        }

        [When(@"I click Create")]
        public void WhenIClickCreate()
        {
            Website.AdminCourseCreatePage.ClickCreateButton();
        }

        [Then(@"I won't be returned to the course page")]
        public void ThenIWonTBeReturnedToTheCoursePage()
        {
            Website.SeleniumDriver.Url.Contains("Create");
        }

        [Then(@"I am taken to the Course create page")]
        public void ThenIAmTakenToTheCourseCreatePage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Create"));
        }
    }            
}
