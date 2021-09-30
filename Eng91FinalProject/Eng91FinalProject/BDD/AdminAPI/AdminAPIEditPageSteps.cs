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
    [Scope(Feature = "AdminAPIEditPage")]
    public class AdminAPIEditPageSteps : SharedNavbarSteps
    {        
        [When(@"I click ‘EDIT’ on '(.*)'")]
        public void WhenIClickEDITOn(string api)
        {
            Website.AdminAPIPage.ClickEditButton(api);
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
            Website.AdminAPIEditPage.ClickSaveButton();
        }
        
        [Then(@"I am taken to the Admin API Edit Page")]
        public void ThenIAmTakenToTheAdminAPIEditPage()
        {
            Assert.That(Website.AdminAPIEditPage.GetPageTitle(), Does.Contain("Edit"));
        }
        
        [Then(@"the API Key & API Token is edited")]
        public void ThenTheAPIKeyAPITokenIsEdited()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("APIAdmin"));
        }
    }
}
