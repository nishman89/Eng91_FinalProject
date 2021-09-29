using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TraineeProfile")]
    public class TraineeProfileSteps : SharedNavbarSteps
    {
        [Then(@"I am taken to my Profile Page")]
        public void ThenIAmTakenToMyProfilePage()
        {
            Assert.That(base.Website.SeleniumDriver.Url, Does.Contain("Profile/View"));
        }
        
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
