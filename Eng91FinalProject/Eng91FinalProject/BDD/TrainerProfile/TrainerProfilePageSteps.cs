
using TechTalk.SpecFlow;
using NUnit.Framework;
using Eng91FinalProject.utils;
using TechTalk.SpecFlow.Assist;
using System.Threading;

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
            base.Website.SeleniumDriver.Manage().Window.FullScreen();
        }

        [When(@"I click EDIT")]
        public void WhenIClick()

        {
            base.Website.SeleniumDriver.Manage().Window.FullScreen();
            base.Website.TrainerProfilePage.ClickEditButton();
        }

        [When(@"I update my details with the following information")]
        public void WhenIUpdateMyDetails(Table table)
        {
            _trainerProfileDetails = table.CreateInstance<TrainerProfileDetails>();
            base.Website.TrainerProfileEditPage.InputFormDetails(_trainerProfileDetails);
            //Thread.Sleep(5000);
        }

        [When(@"I click SAVE")]
        public void WhenIClickSAVE()
        {
            base.Website.TraineeProfileEditPage.ClickSaveButton();
        }

        //[When(@"change my stream to C\# Developer")]
        //public void WhenChangeMyStreamToCDeveloper()
        //{
        //    base.Website.TrainerProfileEditPage.ClearStreamsSelection();
        //    base.Website.TrainerProfileEditPage.SelectStreamsDropdown();
        //    base.Website.TrainerProfileEditPage.SelectStreamsDropdownSelectCsharpDev();
        //    base.Website.TrainerProfileEditPage.SelectStreamsDropdown();
        //    Thread.Sleep(5000);
        //}

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

        [When(@"change my stream to '(.*)'")]
        public void WhenChangeMyStreamTo(string course)
        {
            base.Website.TrainerProfileEditPage.ClearStreamsDropdown();
            base.Website.TrainerProfileEditPage.SelectStream(course);
            Thread.Sleep(5000);
        }

        [Then(@"my profile details for course stream should show '(.*)'")]
        public void ThenMyProfileDetailsForCourseStreamShouldShow(string course)
        {
            Assert.That(base.Website.TrainerProfilePage.GetStreams(),Is.EqualTo(course));
        }






    }
}
