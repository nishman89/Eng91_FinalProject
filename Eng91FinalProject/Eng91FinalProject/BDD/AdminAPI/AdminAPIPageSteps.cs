using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Eng91FinalProject.BDD.AdminAPI
{
    [Binding]
    [Scope(Feature = "AdminAPIPage")]
    public class AdminAPIPageSteps : SharedNavbarSteps
    {
        private string _savedApiKey;

        [When(@"I click ‘Edit’ on '(.*)'")]
        public void WhenIClickEditOn(string api)
        {
            Website.AdminAPIPage.ClickEditButton(api);
        }

        [When(@"I click ‘OK’")]
        public void WhenIClickOK()
        {
            Website.AdminAPIPage.ClickOkButton();
        }

        [When(@"I click ‘CANCEL’")]
        public void WhenIClickCANCEL()
        {
            Website.AdminAPIPage.ClickCancelButton();
        }

        [When(@"I click ‘DELETE’ on '(.*)'")]
        public void WhenIClickDELETEOn(string api)
        {
            Website.AdminAPIPage.ClickDeleteButton(api);
        }

        [When(@"I click ‘DISABLE’ on '(.*)'")]
        public void WhenIClickDISABLEOn(string api)
        {
            Website.AdminAPIPage.ClickDisableButton(api);
        }

        [When(@"I click ‘RESET’ on '(.*)'")]
        public void WhenIClickRESETOn(string api)
        {
            WhenIClickTheNameOfTheAPIOn(api);
            Thread.Sleep(5000);
            _savedApiKey = Website.AdminAPIPage.APIInformation(api);
            Website.AdminAPIPage.ClickResetButton(api);
        }

        [When(@"I click ‘ENABLE’ on '(.*)'")]
        public void WhenIClickENABLEOn(string api)
        {
            Website.AdminAPIPage.ClickEnableButton(api);
        }

        [When(@"I click the name of the API on '(.*)'")]
        public void WhenIClickTheNameOfTheAPIOn(string api)
        {
            Website.AdminAPIPage.ExpandAPI(api);
        }

        [Then(@"I am taken to the Admin API Page")]
        public void ThenIAmTakenToTheAdminAPIPage()
        {
            Assert.That(Website.SeleniumDriver.Url, Does.Contain("APIAdmin"));
        }

        [Then(@"I am taken to the Admin API Edit Page")]
        public void ThenIAmTakenToTheAdminAPIEditPage()
        {
            Assert.That(Website.AdminAPIEditPage.GetPageTitle(), Does.Contain("Edit"));
        }

        [Then(@"the selected API Key & Token is deleted on '(.*)'")]
        public void ThenTheSelectedAPIKeyTokenIsDeletedOn(string api)
        {
            Assert.Throws<NoSuchElementException>(delegate { Website.AdminAPIPage.ClickEditButton(api); });
        }

        [Then(@"the selected API is disabled on '(.*)'")]
        public void ThenTheSelectedAPIIsDisabledOn(string api)
        {
            Assert.That(Website.AdminAPIPage.IsDisabled(api), Does.Contain("ENABLE"));
        }

        [Then(@"the selected API is enabled on '(.*)'")]
        public void ThenTheSelectedAPIIsEnabledOn(string api)
        {
            Assert.That(Website.AdminAPIPage.IsEnabled(api), Does.Contain("DISABLE"));
        }

        [Then(@"the selected API is reset on '(.*)'")]
        public void ThenTheSelectedAPIIsResetOn(string api)
        {
            WhenIClickTheNameOfTheAPIOn(api);
            Thread.Sleep(5000);
            Assert.That(Website.AdminAPIPage.APIInformation(api), Does.Not.Contain(_savedApiKey));
        }

        [Then(@"the selected API information is shown on '(.*)'")]
        public void ThenTheSelectedAPIInformationIsShownOn(string api)
        {
            Thread.Sleep(5000);
            Assert.That(Website.AdminAPIPage.DisplayAPIInformation(api), Is.True);
        }
    }
}
