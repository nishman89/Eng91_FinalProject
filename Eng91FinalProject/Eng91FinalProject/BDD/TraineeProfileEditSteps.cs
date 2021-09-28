using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TraineeProfileEdit")]
    public class TraineeProfileEditSteps : SharedSteps
    {
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click my name to view my Profile Page")]
        public void WhenIClickMyNameToViewMyProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click ‘EDIT’")]
        public void WhenIClickEDIT()
        {
            Website.TraineeProfilePage.ClickEditButton();
        }

        [When(@"I update my details")]
        public void WhenIUpdateMyDetails()
        {
            Website.TraineeProfileEditPage.InputSummary(string summary);
            Website.TraineeProfileEditPage.InputLifeStory(string lifeStory);
            Website.TraineeProfileEditPage.InputCareerMotivation(string careerMotivation);
            Website.TraineeProfileEditPage.InputSkills(string skills);
            Website.TraineeProfileEditPage.InputInterests(string interests);
            Website.TraineeProfileEditPage.InputEducation(string education);
            Website.TraineeProfileEditPage.InputCertifications(string certifications);
            Website.TraineeProfileEditPage.InputAdditionalAchievements(string additionalAchievements);
            Website.TraineeProfileEditPage.InputRecentEmployment(string recentEmployment);
            Website.TraineeProfileEditPage.InputVolunteering(string volunteering);
            Website.TraineeProfileEditPage.InputLinkedIn(string linkedIn);
            Website.TraineeProfileEditPage.InputGithub(string github);
        }

        [When(@"I click ‘SAVE’")]
        public void WhenIClickSAVE()
        {
            Website.TraineeProfileEditPage.ClickSaveButton();
        }

        [Then(@"my profile is updated")]
        public void ThenMyProfileIsUpdated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
