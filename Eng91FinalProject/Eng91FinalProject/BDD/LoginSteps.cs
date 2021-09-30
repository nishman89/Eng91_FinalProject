using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace Eng91FinalProject
{
    [Binding]
    [Scope(Feature = "Login")]
    public class LoginSteps : SharedLoginSteps
    {
        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string message)
        {
            Assert.That(Website.LoginPage.GetErrorMessage(), Is.EqualTo(message));
        }

    }
}
