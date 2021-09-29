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

    }
}
