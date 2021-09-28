using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Eng91FinalProject.BDD
{
    [Binding]
    public class AdminCourseEditPageSteps : SharedLoginSteps
    {
        [Then(@"the selected course can be edited")]
        public void ThenTheSelectedCourseCanBeEdited()
        {
            Assert.That(Website.SeleniumDriver.Url.Contains("Edit"));
        }
    }
}
