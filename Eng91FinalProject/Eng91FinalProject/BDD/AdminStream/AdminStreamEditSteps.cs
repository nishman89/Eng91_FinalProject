using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminStream
{
    [Binding]
    [Scope(Tag ="AdminStreamEdit")]
    public class AdminStreamEditSteps : SharedLoginSteps
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
        
        [When(@"I click Edit on '(.*)'")]
        public void WhenIClickEditOn(string streamName)
        {
            string formattedStream = Website.AdminStreamPage.FormatStream(streamName);
            Website.AdminStreamPage.EditStream(formattedStream);
        }
        
        [Then(@"I should be taken to the Edit page")]
        public void ThenIShouldBeTakenToTheEditPage()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Record"));
        }
    }
}
