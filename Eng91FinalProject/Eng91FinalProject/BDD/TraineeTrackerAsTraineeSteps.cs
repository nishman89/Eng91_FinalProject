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
    public class TraineeTrackerAsTraineeSteps : SharedLoginSteps
    {
        
        [When(@"I press Tracker")]
        public void WhenIPressTracker()
        {
            Website.TraineeTrackerPage.PressTrackerButton();
        }
        
        [Then(@"tI should see my tracker/s")]
        public void ThenTIShouldSeeMyTrackerS()
        {
            Assert.That(Website.TraineeTrackerPage.WhatIassumeToBeTheContentBox(), Is.True);
        }
    }
}
