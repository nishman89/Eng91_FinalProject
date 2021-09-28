using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Eng91FinalProject.utils;
using TechTalk.SpecFlow.Assist;

namespace Eng91FinalProject.BDD.TrainerProfile
{
    [Binding]
    [Scope(Feature = "TrainerProfilePage")]
    public sealed class TrainerProfilePageSteps : SharedLoginSteps
    {
        private TrainerProfileDetails _trainerProfileDetails;

        [When(@"I click my name to view my Profile Page")]
        public void WhenIClickMyNameToViewMyProfilePage()
        {
            base.Website.TrainerNavbar.ClickTrainerProfileButton();
        }

        [When(@"I click EDIT")]
        public void WhenIClick()
        {
            base.Website.TrainerProfilePage.ClickEditButton();
        }

        [When(@"I update my details with the following information")]
        public void WhenIUpdateMyDetails(Table table)
        {
            _trainerProfileDetails = table.CreateInstance<TrainerProfileDetails>();
            base.Website.TrainerProfileEditPage.InputFormDetails(_trainerProfileDetails);
        }

        [When(@"I click SAVE")]
        public void WhenIClickSAVE()
        {
            base.Website.TraineeProfileEditPage.ClickSaveButton();
        }

        [Then(@"I am taken to my Profile Page")]
        public void ThenIAmTakenToMyProfilePage()

        {
            //title page - index
            Assert.That(base.Website.TrainerProfilePage.GetPageTitle(), Does.Contain("Index"));
        }

        [Then(@"my profile is updated")]
        public void ThenMyProfileIsUpdated()
        {
            var testEmail = Website.TrainerProfilePage.GetEmail();
            var testLocation = Website.TrainerProfilePage.GetLocation();
            var testName = Website.TrainerProfilePage.GetProfileName();

            Assert.That(testEmail, Is.EqualTo(_trainerProfileDetails.Email));
            Assert.That(testLocation, Is.EqualTo(_trainerProfileDetails.Location));
            Assert.That(testName, Is.EqualTo($"{_trainerProfileDetails.FirstName} {_trainerProfileDetails.LastName}"));
        }

    }
}
