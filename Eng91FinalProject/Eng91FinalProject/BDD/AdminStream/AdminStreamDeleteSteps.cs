using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminStream
{
    [Binding]
    [Scope(Tag = "AdminStreamDelete")]
    public class AdminStreamDeleteSteps : SharedLoginSteps
    {
        [Given(@"I click Admin")]
        public void GivenIClickAdmin()
        {
            Website.TrainerNavbar.ClickAdminDropdownButton();
        }
        
        [Given(@"I click Streams")]
        public void GivenIClickStreams()
        {
            Website.TrainerNavbar.ClickAdminDropdownStreamsButton();
        }

        [When(@"I click Delete on '(.*)'")]
        public void WhenIClickDeleteOn(string stream)
        {
            string formattedStream = Website.AdminStreamPage.FormatStream(stream);
            Website.AdminStreamPage.DeleteStream(formattedStream);
        }

        [Then(@"I should be taken to the Delete page")]
        public void ThenIShouldBeTakenToTheDeletePage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Delete"));
        }
    }
}
