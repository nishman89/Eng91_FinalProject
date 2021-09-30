using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TraineeTrackerAsTrainer")]
    public class TraineeTrackerAsTrainerSteps : SharedLoginSteps
    {
        [When(@"I press Tracker")]
        public void WhenIPressTracker()
        {
            Website.TrainerTrackerPage.TraineeTrackerButton();
        }
        [Then(@"I should see my trainee trackers")]
        public void ThenIShouldSeeMyTraineeTrackers()
        {
            Assert.That(Website.TrainerTrackerPage.IsInTrackerPage(), Is.True);
        }
        [When(@"I press Edit")]
        public void ThenIPressEdit()
        {
            Website.TrainerTrackerPage.ClickEditButton_BenHoward();
        }

        [When(@"I manage the (.*) section")]
        public void WhenIManageTheSection(string message)
        {
            Website.TrainerTrackerPage.ManageComment(message);
        }


        [When(@"I press save")]
        public void WhenIPressSave()
        {
            Website.TrainerTrackerPage.SaveChanges();
        }

        [When(@"I max the first user grades")]
        public void WhenIMaxTheFirstUserGrades()
        {
            //Needs fixing
            Website.TrainerTrackerPage.MaxTechGradeByText();
        }

        [Then(@"his grades are maxed")]
        public void ThenHisGradesAreMaxed_()
        {
            var tupple = Website.TrainerTrackerPage.ReturnGrades();
            Assert.That(tupple.Item1, Is.EqualTo("A+"));
            Assert.That(tupple.Item2, Is.EqualTo("A+"));
            Assert.That(tupple.Item3, Is.EqualTo("A+"));
        }
        [When(@"I press Trainee Tracker")]
        public void WhenIPressTraineeTracker()
        {
            Website.TrainerTrackerPage.TraineeTrackerButton();
        }

    }
}
