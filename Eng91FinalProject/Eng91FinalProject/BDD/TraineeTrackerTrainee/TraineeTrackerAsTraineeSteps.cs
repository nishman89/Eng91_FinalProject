using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TraineeTrackerAsTrainee")]
    public class TraineeTrackerAsTraineeSteps : SharedLoginSteps
    {
        
        [When(@"I press Tracker")]
        public void WhenIPressTracker()
        {
            Website.TraineeTrackerPage.PressTrackerButton();
        }
        
        [Then(@"I should see my trackers")]
        public void ThenTIShouldSeeMyTrackerS()
        {
            Assert.That(Website.TraineeTrackerPage.CanICreateNewTracker(), Is.True);
        }
        [When(@"I press Edit")]
        public void WhenIPressEdit()
        {
            Website.TraineeTrackerPage.PressEditTrackerButton();
        }

        [Then(@"The window to edit the tracker appears")]
        public void ThenTheWindowToEditTheTrackerAppears()
        {
            Assert.That(Website.TraineeTrackerPage.IsInEditPage(), Is.True);
        }
        [When(@"I manage the Stop section with the feedback (.*)")]
        public void WhenIManageTheStopSectionWithTheFeedback(string message)
        {
            Website.TraineeTrackerPage.ManageStop(message);
        }

        [When(@"I press save")]
        public void WhenIPressSave()
        {
            Website.TraineeTrackerPage.SaveChanges();
        }
        [When(@"I manage the Start section with the feedback (.*)")]
        public void WhenIManageTheStartSectionWithTheFeedback(string message)
        {
            Website.TraineeTrackerPage.ManageStart(message);
        }
        [When(@"I manage the Continue section with the feedback (.*)")]
        public void WhenIManageTheContinueSectionWithTheFeedback(string message)
        {
            Website.TraineeTrackerPage.ManageContinue(message);
        }


        [When(@"I press create new Tracker")]
        public void WhenIPressCreateNewTracker()
        {
            Website.TraineeTrackerPage.PressCreateNewTacker();
        }


    }
}
