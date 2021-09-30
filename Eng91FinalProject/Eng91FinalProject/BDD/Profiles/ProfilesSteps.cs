using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.Profiles
{
    [Binding]
    [Scope(Feature = "Profiles")]
    public class ProfilesSteps : SharedLoginSteps
        
    {
        [When(@"I click 'Profiles'")]
        public void WhenIClick()
        {
            Website.TrainerNavbar.ClickProfilesButton();
        }

        [When(@"I click on a trainee's profile")]
        public void WhenIClickOnATraineeProfile()
        {
            Website.ProfilesPage.SelectProfile(1);
            Website.ProfilesPage.ClickSelectedProfile();          
        }

        [Then(@"I can view that trainee's profile")]
        public void ThenICanViewThatTraineeSProfile()
        {
            Assert.That(Website.SeleniumDriver.Url, Does.Contain("Profile/View/1"));
        }

        [Then(@"I can view all of the profiles")]
        public void ThenICanViewAllOfTheProfiles()
        {
            var allProfiles = Website.ProfilesPage.GetAllProfileNames();
            var allViewdProfiles = Website.ProfilesPage.GetAllViewedProfileNames();

            CollectionAssert.AreEqual(allProfiles, allViewdProfiles);
        }


    }
}
