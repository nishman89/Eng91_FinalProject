using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Eng91FinalProject.utils;
using TechTalk.SpecFlow.Assist;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TraineeProfileEdit")]
    public class TraineeProfileEditSteps : SharedLoginSteps
    {
        [When(@"I click my name to view my Profile Page")]
        public void WhenIClickMyNameToViewMyProfilePage()
        {
            base.Website.TraineeNavbar.ClickTraineeProfile();
        }

        [When(@"I click ‘EDIT’")]
        public void WhenIClickEDIT()
        {
            Website.TraineeProfilePage.ClickEditButton();
        }

        [When(@"I update my details")]
        public void WhenIUpdateMyDetails(Table table)
        {
            _traineeProfileDetails = table.CreateInstance<TraineeProfileDetails>();
            Website.TraineeProfileEditPage.InputFormDetails(_traineeProfileDetails);
        }

        [When(@"I click ‘SAVE’")]
        public void WhenIClickSAVE()
        {
            Website.TraineeProfileEditPage.ClickSaveButton();
        }

        [Then(@"my profile is updated")]
        public void ThenMyProfileIsUpdated()
        {
            Assert.That(Website.TraineeProfilePage.GetSummaryBoxText(), Does.Contain("test"));
        }

    }
}
