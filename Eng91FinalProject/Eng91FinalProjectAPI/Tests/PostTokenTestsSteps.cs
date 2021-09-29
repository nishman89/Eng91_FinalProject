using NUnit.Framework;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Eng91FinalProjectAPI.Tests
{
    [Binding]
    [Scope(Feature ="PostTokenTests")]
    public class PostTokenTestsSteps : SharedSteps
    {
        [Given(@"I have an approved key")]
        public void GivenIHaveAnApprovedKey()
        {
            _traineeService.CallManager.APIKey = "SexLEYatCnW5x3lri//G6EnE3a9egpV3U2xIsLINR3M=";
        }
        
        [Given(@"I make a request for a token")]
        public async Task GivenIMakeARequestForAToken()
        {
            await _traineeService.MakeTokenRequestAsync();
        }
        
        [Then(@"I should recieve a valid token")]
        public void ThenIShouldRecieveAValidToken()
        {
            Assert.That(_traineeService.TokenResponseDTO.Response.token, Is.EqualTo("/raHHLG3CkngPn73rvHVj1AsQpMxoJvD8Ck93GwnCK4="));
        }
    }
}
