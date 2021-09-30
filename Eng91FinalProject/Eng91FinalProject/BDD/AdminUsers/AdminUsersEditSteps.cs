using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminUsers
{
    [Binding]
    [Scope(Tag= "AdminUsersEdit")]
    public class AdminUsersEditSteps : SharedLoginSteps
    {
        [Given(@"I click Admin")]
        public void GivenIClickAdmin()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
        }
        
        [Given(@"I click Users")]
        public void GivenIClickUsers()
        {
            Website.TrainerNavbar.ClickAdminDropdownUsersButton();
        }
        
        [When(@"I click Edit on '(.*)'")]
        public void WhenIClickEditOn(string user)
        {
            Website.AdminUsersPage.EditUser(user);
        }
        
        [Then(@"I should be taken to the edit page")]
        public void ThenIShouldBeTakenToTheEditPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Edit"));
        }
    }
}
