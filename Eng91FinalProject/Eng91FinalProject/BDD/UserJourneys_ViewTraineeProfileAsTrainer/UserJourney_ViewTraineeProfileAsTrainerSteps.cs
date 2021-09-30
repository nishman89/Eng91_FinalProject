using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "UserJourney_ViewTraineeProfileAsTrainer")]
    public sealed class UserJourney_ViewTraineeProfileAsTrainerSteps : SharedLoginSteps
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
    }
}
