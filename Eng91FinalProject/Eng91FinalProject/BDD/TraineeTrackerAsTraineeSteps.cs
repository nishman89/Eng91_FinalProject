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

    }
}
