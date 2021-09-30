using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney_TrainerLogin_Courses_AddNewCourse")]
    public class UserJourney_TrainerLogin_Courses_AddNewCourseSteps : SharedNavbarSteps
    {
        AdminCourseCreatePageSteps _createPageSteps = new AdminCourseCreatePageSteps();
        AdminCoursePageSteps _coursePageSteps = new AdminCoursePageSteps();
        [BeforeScenario]
        public void InstantiateSteps()
        {
            _coursePageSteps.Website.SeleniumDriver.Quit();
            _createPageSteps.Website.SeleniumDriver.Quit();
            _coursePageSteps.Website = Website;
            _createPageSteps.Website = Website;
        }

        [When(@"I enter the correct credentials")]
        public void WhenIEnterTheCorrectCredentials(Table table)
        {
            base.WhenIEnterTheFollowingCredentials(table);
        }

        [When(@"I click ‘Courses’ in the drop-down menu")]
        public void WhenIClickCoursesInTheDrop_DownMenu()
        {
            _coursePageSteps.GivenIClickCourses();
        }

        [When(@"I click ‘New’")]
        public void WhenIClickNew()
        {
            _createPageSteps.WhenIClickNew();
        }

        [When(@"I enter the desired course details")]
        public void WhenIEnterTheDesiredCourseDetails(Table table)
        {
            _createPageSteps.WhenIEnterTheDesiredCourseDetails(table);
        }

        [When(@"I click ‘CREATE’")]
        public void WhenIClickCREATE()
        {
            _createPageSteps.WhenIClickCreate();
        }

        [Then(@"the new course is created")]
        public void ThenTheNewCourseIsCreated()
        {
            _createPageSteps.ThenTheNewCourseIsCreated();
        }
    }
}
