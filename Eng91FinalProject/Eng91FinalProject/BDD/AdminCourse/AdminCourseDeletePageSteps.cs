using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Tag = "AdminCourseDelete")]
    public class AdminCourseDeletePageSteps : SharedLoginSteps
    {
        [Given(@"I click Courses")]
        public void GivenIClickCourses()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
        }

        [When(@"I click Delete on '(.*)'")]
        public void WhenIClickDeleteOn(string course)
        {
            string formatCourse = Website.AdminCoursesPage.FormatSearch(course);
            Website.AdminCoursesPage.DeleteCourse(formatCourse);
        }

        [When(@"I click Back to List")]
        public void WhenIClickBackToList()
        {
            Website.AdminCourseDeletePage.BackToList();
        }

        [Then(@"I should be taken to the courses page")]
        public void ThenIShouldBeTakenToTheCoursesPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Course"));
        }


        [Then(@"I should be taken to the delete course page")]
        public void ThenIShouldBeTakenToTheDeleteCoursePage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Delete"));
        }

    }
}
