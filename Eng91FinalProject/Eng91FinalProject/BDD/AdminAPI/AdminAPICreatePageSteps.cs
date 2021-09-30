using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace Eng91FinalProject.BDD.AdminAPI
{
    [Binding]
    [Scope(Feature = "AdminAPICreatePage")]
    public class AdminAPICreatePageSteps : SharedNavbarSteps
    {        
        [When(@"I click ‘NEW’")]
        public void WhenIClickNEW()
        {
            Website.AdminAPIPage.ClickNewButton();
        }

        [When(@"I enter the Reference Name '(.*)'")]
        public void WhenIEnterTheReferenceName(string name)
        {
            Website.AdminAPICreatePage.InputReferenceName(name);
        }

        [When(@"I enter the Key Expiration date/time '(.*)'")]
        public void WhenIEnterTheKeyExpirationDateTime(string date)
        {
            Website.AdminAPICreatePage.InputExpirationDate(date);
        }

        [When(@"I enter the Request Limit '(.*)'")]
        public void WhenIEnterTheRequestLimit(string limit)
        {
            Website.AdminAPICreatePage.InputRequestLimit(limit);
        }

        [When(@"I click ‘Disabled’")]
        public void WhenIClickDisabled()
        {
            Website.AdminAPICreatePage.CheckDisabledBox();
        }

        [When(@"I click ‘SAVE’")]
        public void WhenIClickSAVE()
        {
            Website.AdminAPICreatePage.ClickSaveButton();
        }

        [Then(@"a new API Key & API Token is created")]
        public void ThenANewAPIKeyAPITokenIsCreated()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("APIAdmin"));
        }

        [Then(@"I am taken to the Admin API Create Page")]
        public void ThenIAmTakenToTheAdminAPICreatePage()
        {
            Assert.That(Website.AdminAPICreatePage.GetPageTitle(), Does.Contain("New"));
        }

        [Then(@"a new disabled API Key & API Token is created on '(.*)'")]
        public void ThenANewDisabledAPIKeyAPITokenIsCreatedOn(string api)
        {
             Assert.That(Website.AdminAPIPage.IsDisabled(api), Does.Contain("ENABLE"));
        }

        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string error)
        {
            Assert.That(Website.AdminAPICreatePage.GetErrorMessage(), Does.Contain(error));
        }
    }
}
