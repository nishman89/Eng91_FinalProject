using Eng91FinalProjectAPI.Services;
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
        [BeforeScenario]
        public void OneTimeSetUpAsync()
        {
            _service = new TokenService();
        }

        [Given(@"I have an approved key")]
        public void GivenIHaveAnApprovedKey()
        {
            _service.CallManager.APIKey = AppConfigReader.ApiKey;
        }

        [Given(@"I have an invalid key")]
        public void GivenIHaveAnInvalidKey()
        {
            _service.CallManager.APIKey = "notavalidkey";
        }

        [Given(@"I have a disabled key")]
        public void GivenIHaveADisabledKey()
        {
            _service.CallManager.APIKey = AppConfigReader.DisabledAPIKey;
        }


        [Given(@"I make a request for a token")]
        public async Task GivenIMakeARequestForAToken()
        {
            await ((TokenService)_service).MakeTokenRequestAsync();
        }
        
        [Then(@"I should receive a valid token")]
        public void ThenIShouldReceiveAValidToken()
        {
            Assert.That(((TokenService)_service).TokenResponseDTO.Response.token, Is.EqualTo("/raHHLG3CkngPn73rvHVj1AsQpMxoJvD8Ck93GwnCK4="));
        }
    }
}
