using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminStream
{
    [Binding]
    [Scope(Tag ="AdminStreamCreate")]
    public class AdminStreamCreateSteps : SharedLoginSteps
    {
        [Given(@"I click Admin")]
        public void GivenIClickAdmin()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
        }
        
        [Given(@"I click Stream")]
        public void GivenIClickStream()
        {
            Website.TrainerNavbar.ClickAdminDropdownStreamsButton();
        }
        
        [When(@"I click New")]
        public void WhenIClickNew()
        {
            Website.AdminStreamPage.ClickCreateNew();
        }
        
        [Then(@"I should be taken to the create a stream page")]
        public void ThenIShouldBeTakenToTheCreateAStreamPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Record"));
        }
    }
}
