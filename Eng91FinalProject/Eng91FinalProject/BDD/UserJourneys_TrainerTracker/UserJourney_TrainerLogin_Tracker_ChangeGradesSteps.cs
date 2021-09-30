using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney_TrainerLogin_Tracker_ChangeGrades")]
    public class UserJourney_TrainerLogin_Tracker_ChangeGradesSteps : SharedLoginSteps
    {
        TraineeTrackerAsTrainerSteps trainerSteps = new TraineeTrackerAsTrainerSteps();

        [BeforeScenario]
        public void InstantiateSteps()
        {
            trainerSteps.Website.SeleniumDriver.Quit();
            trainerSteps.Website = Website;
        }

        [When(@"I press Tracker")]
        public void WhenIPressTracker()
        {
            trainerSteps.WhenIPressTracker();
        }

        [When(@"I press Edit")]
        public void WhenIPressEdit()
        {
            trainerSteps.ThenIPressEdit();
        }

        [When(@"I max the first user grades")]
        public void WhenIMaxTheFirstUserGrades()
        {
            trainerSteps.WhenIMaxTheFirstUserGrades();
        }

        [When(@"I press save")]
        public void WhenIPressSave()
        {
            trainerSteps.WhenIPressSave();
        }

        [Then(@"I should see my trainee trackers")]
        public void ThenIShouldSeeMyTraineeTrackers()
        {
            trainerSteps.ThenIShouldSeeMyTraineeTrackers();
        }

        [Then(@"his grades are maxed")]
        public void ThenHisGradesAreMaxed()
        {
            trainerSteps.ThenHisGradesAreMaxed_();
        }


    }
}
