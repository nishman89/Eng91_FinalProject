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
    [Scope(Feature = "TraineeProfile")]
    public class TraineeProfileSteps : SharedNavbarSteps
    {
        [Then(@"I am taken to my Profile Edit Page")]
        public void ThenIAmTakenToMyProfileEditPage()
        {
            Assert.That(base.Website.SeleniumDriver.Url, Does.Contain("Profile/Edit"));
        }

        [When(@"I click ‘EDIT’")]
        public void WhenIClickEDIT()
        {
            Website.TraineeProfilePage.ClickEditButton();
        }
    }
}
