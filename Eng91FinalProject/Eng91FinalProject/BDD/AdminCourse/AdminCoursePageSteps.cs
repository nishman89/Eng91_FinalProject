using Eng91FinalProject.BDD.AdminCourse;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Tag = "AdminCourse")]
    public class AdminCoursePageSteps : AdminCourseSharedSteps
    {

        [Given(@"I click Courses")]
        public void GivenIClickCourses()

        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
            Website.TrainerNavbar.ClickAdminDropdownCoursesButton();
        }

        [When(@"I type '(.*)' in search bar")]
        public void WhenITypeInSearchBar(string course)
        {
            Website.AdminCoursesPage.Search(course);
        }

        [When(@"I click Search")]
        public void WhenIClickSearch()
        {
            Website.AdminCoursesPage.ClickSearch();
        }

        [Then(@"'(.*)' does not appear")]
        public void ThenDoesNotAppear(string course)
        {
            string formatCourse = Website.AdminCoursesPage.FormatSearch(course);
            Assert.Throws<NoSuchElementException>(delegate { Website.AdminCoursesPage.SearchResult(formatCourse); });
        }
    }
}
