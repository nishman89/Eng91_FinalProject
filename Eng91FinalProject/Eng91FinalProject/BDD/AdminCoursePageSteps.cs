using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Tag = "AdminCourse")]
    public class AdminCoursePageSteps : SharedLoginSteps
    {
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {

        }

        [Given(@"I click '(.*)'")]
        public void GivenIClick(string p0)
        {
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
        }
        
        [When(@"I type '(.*)' in search bar")]
        public void WhenITypeInSearchBar(string course)
        {
            Website.AdminCoursesPage.Search(course);
        }
        
        [When(@"I click '(.*)'")]
        public void WhenIClick(string page)
        {
            Website.AdminCoursesPage.ClickSearch();
        }
        
        [Then(@"the result should show '(.*)'")]
        public void ThenTheResultShouldShow(string expected)
        {
            Assert.That(Website.AdminCoursesPage.SearchResult(), Is.EqualTo(expected));
        }
    }
}
