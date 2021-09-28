using Eng91FinalProjectAPI.Services;
using NUnit.Framework;
using System;
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
        public void GivenIMakeAGetRequestForTrainees()
        {
            _traineeService.MakeTraineeRequestAsync();
        }
        
        [Then(@"I should receive a JSON of all trainees")]
        public void ThenIShouldReceiveAJSONOfAllTrainees()
        {
            Assert.That(_traineeService.TraineeResponseDTO, Is.Not.Null);
        }
    }
}
