using APIMiniProject;
using RestSharp;
using System.Threading.Tasks;

namespace Eng91FinalProjectAPI.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;

        public int StatusCode { get; private set; }
        public string AuthorisationToken { get; set; } = "raHHLG3CkngPn73rvHVj1AsQpMxoJvD8Ck93GwnCK4=";
        public enum GetMethods
        {
            Trainees,
            Profiles
        }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakeGetRequestAsync(GetMethods method)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"/{method.ToString().ToLower()}";
            request.AddHeader("Authorization", $"Bearer /{AuthorisationToken}");
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

    }
}
