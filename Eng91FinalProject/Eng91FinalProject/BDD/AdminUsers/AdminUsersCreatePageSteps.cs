using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminUsers
{
    [Binding]
    [Scope(Tag ="AdminUserCreate")]
    public class AdminUsersCreatePageSteps : SharedLoginSteps
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
        
        [When(@"I click New")]
        public void WhenIClickNew()
        {
            Website.AdminUsersPage.CreateNewUser();
        }
        
        [Then(@"I should be taken to the create a user page")]
        public void ThenIShouldBeTakenToTheCreateAUserPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Create"));
        }
    }
}
