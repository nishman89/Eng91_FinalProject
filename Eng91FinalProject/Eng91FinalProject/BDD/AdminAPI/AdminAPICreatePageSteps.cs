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


        [When(@"I click ‘SAVE’")]
        public void WhenIClickSAVE()
        {
            Website.AdminAPICreatePage.ClickSaveButton();
        }

        [When(@"I click ‘DISABLE’")]
        public void WhenIClickDISABLE(string api)
        {
            Website.AdminAPIPage.ClickDisableButton(api);
        }

        [When(@"I click ‘ENABLE’")]
        public void WhenIClickENABLE(string api)
        {
            Website.AdminAPIPage.ClickEnableButton(api);
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

        [Then(@"the selected API is disabled")]
        public void ThenTheSelectedAPIIsDisabled(string api)
        {
            Assert.That(Website.AdminAPIPage.IsDisabled(api), Does.Contain("ENABLE"));
        }

        [Then(@"the selected API is enabled")]
        public void ThenTheSelectedAPIIsEnabled(string api)
        {
            Assert.That(Website.AdminAPIPage.IsDisabled(api), Does.Contain("DISABLE"));
        }

    }
}
