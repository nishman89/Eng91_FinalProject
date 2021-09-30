using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminUsers
{
    [Binding]
    [Scope(Tag ="AdminUsers")]
    public class AdminUsersPageSteps : SharedLoginSteps
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
        
        [When(@"I enter '(.*)'")]
        public void WhenIEnter(string user)
        {
            Website.AdminUsersPage.Search(user);
        }
        
        [Then(@"the result should show '(.*)'")]
        public void ThenTheResultShouldShow(string user)
        {
            Assert.That(Website.AdminUsersPage.SearchResult(user), Is.EqualTo(user));
        }
    }
}
