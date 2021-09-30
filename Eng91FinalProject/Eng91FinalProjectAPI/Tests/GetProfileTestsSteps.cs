using Eng91FinalProjectAPI.Services;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Eng91FinalProjectAPI.Tests
{
    [Binding]
    [Scope(Feature ="GetProfileTests")]
    public class GetProfileTestsSteps : SharedSteps
    {
        [BeforeScenario]
        public void OneTimeSetUpAsync()
        {
            _service = new TraineeService();
        }

        [Given(@"I make a get request for profile")]
        public async Task GivenIMakeAGetRequestForProfile()
        {
            await ((TraineeService)_service).MakeProfileRequestAsync();
        }
        
        [Then(@"I should receive a JSON of all profiles")]
        public void ThenIShouldReceiveAJSONOfAllProfiles()
        {
            Assert.That(((TraineeService)_service).TraineeResponseDTO.Response, Is.Not.Null);
        }
    }
}
