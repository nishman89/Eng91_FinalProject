using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney_TraineeLogin_Tracker_UpdateTracker")]
    public class UserJourney_TraineeLogin_Tracker_UpdateTrackerSteps : SharedLoginSteps
    {
        TraineeTrackerAsTraineeSteps traineeSteps = new TraineeTrackerAsTraineeSteps();

        [BeforeScenario]
        public void InstantiateSteps()
        {
            traineeSteps.Website.SeleniumDriver.Quit();
            traineeSteps.Website = Website;
        }
        [When(@"I press Tracker")]
        public void WhenIPressTracker()
        {
            traineeSteps.WhenIPressTracker();
        }

        [When(@"I press Edit")]
        public void WhenIPressEdit()
        {
            traineeSteps.WhenIPressEdit();
        }

        [When(@"I manage the Continue section with the feedback (.*)")]
        public void WhenIManageTheContinueSectionWithTheFeedback(string p0)
        {
            traineeSteps.WhenIManageTheContinueSectionWithTheFeedback(p0);
        }

        [When(@"I press save")]
        public void WhenIPressSave()
        {
            traineeSteps.WhenIPressSave();
        }

        [Then(@"I should see my trackers")]
        public void ThenIShouldSeeMyTrackers()
        {
            traineeSteps.ThenTIShouldSeeMyTrackerS();
        }

    }
}
