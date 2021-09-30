using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using System.Threading;

namespace Eng91FinalProject.BDD
{
    public class SharedNavbarSteps : SharedLoginSteps
    {
        [Given(@"I click ‘Admin’")]
        public void GivenIClickAdmin()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
        }

        [Given(@"I click ‘API’")]
        public void GivenIClickAPI()
        {
            Website.TrainerNavbar.ClickAdminDropdownAPIButton();
        }

        [When(@"I click my name to view my Profile Page")]
        public void WhenIClickMyNameToViewMyProfilePage()
        {
            base.Website.TraineeNavbar.ClickTraineeProfile();
        }

        [When(@"I click ‘Admin’")]
        public void WhenIClickAdmin()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
        }

        [When(@"I click ‘API’")]
        public void WhenIClickAPI()
        {
            Website.TrainerNavbar.ClickAdminDropdownAPIButton();
        }

        [When(@"I click the Sparta Global image")]
        public void WhenIClickTheSpartaGlobalImage()
        {
            Website.SharedNavbar.ClickSpartaGlobalIcon();
        }

        [When(@"I click ‘Home’")]
        public void WhenIClickHome()
        {
            Website.SharedNavbar.ClickHomeButton();
        }

        [Then(@"I am taken to the Profiles Page")]
        public void ThenIAmTakenToTheProfilesPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Profile"));
        }

        [When(@"I click ‘Profiles’")]
        public void WhenIClick()
        {
            Website.TrainerNavbar.ClickProfilesButton();
        }

        [When(@"I click ‘Logout’")]
        public void WhenIClickLogout()
        {
            Website.SharedNavbar.ClickLogoutButton();
        }

        [Then(@"I am logged out and sent to the Splash Page")]
        public void ThenIAmLoggedOutAndSentToTheSplashPage()
        {
            Assert.That(Website.HomePage.IsOnSplashPage(), Is.True);
        }

        [Then(@"I am taken to my Profile Page")]
        public void ThenIAmTakenToMyProfilePage()
        {
            Assert.That(base.Website.SeleniumDriver.Url, Does.Contain("Profile/View").Or.Contain("Trainer"));
        }
    }
}
