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
        [Given(@"I make a get request for profile")]
        public async Task GivenIMakeAGetRequestForProfile()
        {
            await _traineeService.MakeProfileRequestAsync();
        }
        
        [Then(@"I should receive a JSON of all profiles")]
        public void ThenIShouldReceiveAJSONOfAllProfiles()
        {
            Assert.That(_traineeService.TraineeResponseDTO.Response, Is.Not.Null);
        }
    }
}
