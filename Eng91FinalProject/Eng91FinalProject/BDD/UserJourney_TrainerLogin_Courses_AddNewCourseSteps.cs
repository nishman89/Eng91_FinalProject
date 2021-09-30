using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    public class UserJourney_TrainerLogin_Courses_AddNewCourseSteps : SharedNavbarSteps
    {
        AdminCourseCreatePageSteps _createPageSteps = new AdminCourseCreatePageSteps();
        AdminCoursePageSteps _coursePageSteps = new AdminCoursePageSteps();

        [When(@"I enter the correct credentials")]
        public void WhenIEnterTheCorrectCredentials(Table table)
        {
            base.WhenIEnterTheFollowingCredentials(table);
        }

        [When(@"I click ‘Admin’")]
        public void WhenIClickAdmin()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click ‘Courses’ in the drop-down menu")]
        public void WhenIClickCoursesInTheDrop_DownMenu()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click ‘New’")]
        public void WhenIClickNew()
        {
            _createPageSteps.WhenIClickNew();
        }

        [When(@"I enter the desired course details")]
        public void WhenIEnterTheDesiredCourseDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click ‘CREATE’")]
        public void WhenIClickCREATE()
        {
            _createPageSteps.WhenIClickCreate();
        }

        [Then(@"the new course is created")]
        public void ThenTheNewCourseIsCreated(string coursename)
        {
            _coursePageSteps.WhenITypeInSearchBar(coursename);
            _coursePageSteps.WhenIClickSearch();
            _coursePageSteps.ThenTheResultShouldShow(coursename);
        }


    }
}
