using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney_TrainerLogin_Tracker_Comment")]
    public class UserJourney_TrainerLogin_Tracker_Comment : SharedLoginSteps
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

        [When(@"I manage the (.*) section")]
        public void WhenIManageTheSection(string message)
        {
            trainerSteps.WhenIManageTheSection(message);
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


    }
}
