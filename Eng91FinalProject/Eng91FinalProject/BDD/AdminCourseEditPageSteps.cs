using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Tag = "AdminCourseEdit")]
    public class AdminCourseEditPageSteps : SharedLoginSteps
    {
        [Given(@"I click Courses")]
        public void GivenIClickCourses()
        {
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
        }

        [When(@"I click Edit on '(.*)'")]
        public void WhenIClickEditOn(string course)
        {
            Website.AdminCoursesPage.FormatSearch(course);
            Website.AdminCoursesPage.EditCourse(course);
        }

        [Then(@"the selected course can be edited")]
        public void ThenTheSelectedCourseCanBeEdited()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Edit"));
        }
    }
}
