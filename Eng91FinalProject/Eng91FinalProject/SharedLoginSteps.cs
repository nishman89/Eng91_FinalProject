﻿using Eng91FinalProject.lib.pages;
using Eng91FinalProject.utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace Eng91FinalProject
{
    //[Binding]
    //[Scope(Feature = "Login")]
    public class SharedLoginSteps
    {
        public Website<ChromeDriver> Website { get; } = new Website<ChromeDriver>();
        protected Credentials _credentials;

        [Given(@"I am on the Splash Page")]
        public void GivenIAmOnTheSplashPage()
        {
            Website.LoginPage.VisitHomePage();
        }
        
        [Given(@"I click ‘Login’")]
        public void GivenIClickLogin()
        {
            Website.LoginPage.Login();
        }
        
        [When(@"I enter the correct credentials")]
        public void WhenIEnterTheCorrectCredentials(Table table)
        {
            _credentials = table.CreateInstance<Credentials>();

            Website.LoginPage.InputEmail(_credentials.Email);
            Website.LoginPage.InputPassword(_credentials.Password);
        }
        
        [When(@"I click ‘LOGIN’")]
        public void WhenIClickLOGIN()
        {
            Website.LoginPage.LoginSubmit();
        }
        
        [Then(@"I am taken to the Home Page")]
        public void ThenIAmTakenToTheHomePage()
        {
            Assert.That(Website.HomePage.IsOnTrainerHomePage(), Is.True);
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            Website.SeleniumDriver.Quit();
        }
    }
}