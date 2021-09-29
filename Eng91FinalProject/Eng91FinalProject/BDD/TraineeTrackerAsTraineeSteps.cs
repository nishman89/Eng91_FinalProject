using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
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
        
        [Then(@"I should see my tracker/s")]
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
