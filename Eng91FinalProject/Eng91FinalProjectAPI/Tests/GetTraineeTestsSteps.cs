using Eng91FinalProjectAPI.Services;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Eng91FinalProjectAPI.Tests
{
    [Binding]
    public class GetTraineeTestsSteps
    {
        private TraineeService _traineeService;

        [BeforeScenario]
        public async Task OneTimeSetUpAsync()
        {
            _traineeService = new TraineeService();
            await _traineeService.MakeTraineeRequestAsync();
        }

        [Given(@"I have an approved token")]
        public void GivenIHaveAnApprovedToken()
        {
            _traineeService.CallManager.AuthorisationToken = "raHHLG3CkngPn73rvHVj1AsQpMxoJvD8Ck93GwnCK4=";
        }
        
        [Given(@"I make a get request for trainees")]
        public async Task GivenIMakeAGetRequestForTrainees()
        {
            await _traineeService.MakeTraineeRequestAsync();
        }
        
        [Then(@"I should receive a JSON of all trainees")]
        public void ThenIShouldReceiveAJSONOfAllTrainees()
        {
            Assert.That(_traineeService.TraineeResponseDTO.Response, Is.Not.Null);
        }

        [Given(@"I have an unapproved token")]
        public void GivenIHaveAnUnapprovedToken()
        {
            _traineeService.CallManager.AuthorisationToken = "notarealtoken";
        }

        [Given(@"I have a disabled token")]
        public void GivenIHaveADisabledToken()
        {
            _traineeService.CallManager.AuthorisationToken = "/RvsKwG0qzXUfTCk+uJ5/gqaMOFLF8EGofabQQRKYIE=";
        }

        [Then(@"I should receive a status code ""(.*)""")]
        public void ThenIShouldReceiveAStatusCode(int statusCode)
        {
            Assert.That(_traineeService.CallManager.StatusCode, Is.EqualTo(statusCode));
        }

        [Then(@"I should the error message ""(.*)""")]
        public void ThenIShouldTheErrorMessage(string errorMessage)
        {
            Assert.That(_traineeService.ErrorResponseDTO.Response.errors.FirstOrDefault(), Is.EqualTo(errorMessage));
        }

    }
}
