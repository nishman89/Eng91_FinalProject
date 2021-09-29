using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace Eng91FinalProject.BDD
{
    [Binding]
    [Scope(Feature = "TrainerHomePage")]
    public class TrainerHomePageSteps :SharedLoginSteps
    {
        
        
        [When(@"I click EXPAND ALL")]
        public void WhenIClickEXPANDALL()
        {
            Website.HomePage.ClickExpandAndHideAllButton();
        }
        
        [When(@"I click Ben Howard")]
        public void WhenIClickBenHoward()
        {
            Website.HomePage.ClickTrainee1ResultsContainer();
        }
        
        [When(@"I click Phoebe Bridgers")]
        public void WhenIClickPhoebeBridgers()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all test results are shown")]
        public void ThenAllTestResultsAreShown()
        {
            Assert.That(Website.HomePage.IsExpandedAll, Is.EqualTo(true));
            
        }
        
        [Then(@"Ben and Phoebe’s Test Results are shown")]
        public void ThenBenAndPhoebeSTestResultsAreShown()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
