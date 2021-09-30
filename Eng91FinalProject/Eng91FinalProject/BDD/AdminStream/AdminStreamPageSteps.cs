using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD.AdminStream
{
    [Binding]
    [Scope(Tag ="AdminStream")]
    public class AdminStreamPageSteps : SharedLoginSteps
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
        
        [When(@"I type in '(.*)'")]
        public void WhenITypeIn(string streamName)
        {
            Website.AdminStreamPage.InsertDataIntoSearchBar(streamName);
        }
        
        [When(@"I click Search")]
        public void WhenIClickSearch()
        {
            Website.AdminStreamPage.ClickSearchBttn();
        }

        [Then(@"'(.*)' should be returned")]
        public void ThenShouldBeReturned(string streamName)
        {
            string formattedStream = Website.AdminStreamPage.FormatStream(streamName);
            Assert.That(Website.AdminStreamPage.SearchResult(formattedStream),Is.EqualTo(streamName));
        }

    }
}
