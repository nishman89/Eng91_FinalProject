using Eng91FinalProject.BDD.AdminCourse;
using Eng91FinalProject.utils;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Tag = "AdminCourseCreate")]
    public class AdminCourseCreatePageSteps : AdminCourseSharedSteps
    {
        private CourseDetails _courseDetails;

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

        [When(@"I enter the desired course details")]
        public void WhenIEnterTheDesiredCourseDetails(Table table)
        {
            _courseDetails = table.CreateInstance<CourseDetails>();

            Website.AdminCourseCreatePage.InputCourseName(_courseDetails.Name);
            Website.AdminCourseCreatePage.InputCourseLength(_courseDetails.CourseLength);
            Website.AdminCourseCreatePage.InputStartDate(_courseDetails.CourseStart);
        }

        [When(@"I click Courses")]
        public void WhenIClickCourses()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
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

        [Then(@"the new course is created")]
        public void ThenTheNewCourseIsCreated()
        {
            ThenTheResultShouldShow(_courseDetails.Name);
        }
    }
}
