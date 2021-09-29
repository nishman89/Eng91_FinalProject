using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using System.Threading;

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

        [When(@"I click a trainee")]
        public void WhenIClickATrainee()
        {
            base.Website.SeleniumDriver.Manage().Window.Maximize();
            Website.SeleniumDriver.Manage().Window.FullScreen();
            Website.HomePage.ClickTrainee1ResultsContainer();
        }
        
        [Then(@"all test results are shown")]
        public void ThenAllTestResultsAreShown()
        {
            Thread.Sleep(5000);
            Assert.That(Website.HomePage.IsExpandedAll, Is.EqualTo(true));
            
        }  

        [Then(@"That trainee's test results are shown")]
        public void ThenThatTraineeSTestResultsAreShown()
        {
            Thread.Sleep(5000);
            Assert.True(Website.HomePage.IsExpandedBen());
        }

    }
}
