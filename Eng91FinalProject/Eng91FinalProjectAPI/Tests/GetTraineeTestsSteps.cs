using Eng91FinalProjectAPI.Services;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Eng91FinalProjectAPI.Tests
{
    [Binding]
    [Scope(Feature ="GetTraineeTests")]
    public class GetTraineeTestsSteps : SharedSteps
    {
        [BeforeScenario]
        public void OneTimeSetUpAsync()
        {
            _service = new TraineeService();
        }

        [Given(@"I make a get request for trainees")]
        public async Task GivenIMakeAGetRequestForTrainees()
        {
            await ((TraineeService)_service).MakeTraineeRequestAsync();
        }
        
        [Then(@"I should receive a JSON of all trainees")]
        public void ThenIShouldReceiveAJSONOfAllTrainees()
        {
            Assert.That(((TraineeService)_service).TraineeResponseDTO.Response, Is.Not.Null);
        }

    }
}
