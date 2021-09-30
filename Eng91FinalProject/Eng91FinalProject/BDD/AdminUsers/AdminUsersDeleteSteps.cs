using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminUsers
{
    [Binding]
    [Scope(Tag = "AdminUserDelete")]
    public class AdminUsersDeleteSteps : SharedLoginSteps
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
        
        [When(@"I click Delete on '(.*)'")]
        public void WhenIClickDeleteOn(string user)
        {
            Website.AdminUsersPage.DeleteUser(user);
        }
        
        [Then(@"I should be taken to the delete page")]
        public void ThenIShouldBeTakenToTheDeletePage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Delete"));
        }
    }
}
