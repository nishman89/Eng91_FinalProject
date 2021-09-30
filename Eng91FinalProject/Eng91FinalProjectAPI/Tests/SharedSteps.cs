using Eng91FinalProjectAPI.Services;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Eng91FinalProjectAPI.Tests
{

    public class SharedSteps
    {
        protected IService _service;

        [Given(@"I have an approved token")]
        public void GivenIHaveAnApprovedToken()
        {
            _service.CallManager.AuthorisationToken = "/raHHLG3CkngPn73rvHVj1AsQpMxoJvD8Ck93GwnCK4=";
        }

        [Given(@"I have an unapproved token")]
        public void GivenIHaveAnUnapprovedToken()
        {
            _service.CallManager.AuthorisationToken = "notarealtoken";
        }

        [Given(@"I have a disabled token")]
        public void GivenIHaveADisabledToken()
        {
            _service.CallManager.AuthorisationToken = "/RvsKwG0qzXUfTCk+uJ5/gqaMOFLF8EGofabQQRKYIE=";
        }

        [Then(@"I should receive a status code ""(.*)""")]
        public void ThenIShouldReceiveAStatusCode(int statusCode)
        {
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(statusCode));
        }

        [Then(@"I should the error message ""(.*)""")]
        public void ThenIShouldTheErrorMessage(string errorMessage)
        {
            Assert.That(_service.ErrorResponseDTO.Response.errors.FirstOrDefault(), Is.EqualTo(errorMessage));
        }

        [Then(@"I should receive a status code ""(.*)"" in the JSON response")]
        public void ThenIShouldReceiveAStatusCodeInTheJSONResponse(int statusCode)
        {
            Assert.That(_service.CallManager.JSONStatusCode, Is.EqualTo(statusCode));
        }


    }
}
