using APIMiniProject;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace Eng91FinalProjectAPI.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;

        public int StatusCode { get; set; }
        public int JSONStatusCode { get; set; }
        public string AuthorisationToken { get; set; } = "/raHHLG3CkngPn73rvHVj1AsQpMxoJvD8Ck93GwnCK4=";
        public string APIKey { get; set; } = "SexLEYatCnW5x3lri//G6EnE3a9egpV3U2xIsLINR3M=";
        public enum GetMethods
        {
            Trainees,
            Profiles
        }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
            _client.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
        }

        public async Task<string> MakeGetRequestAsync(GetMethods method)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"{method.ToString().ToLower()}";
            request.AddHeader("Authorization", $"Bearer {AuthorisationToken}");
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            if (StatusCode == 200)
            {
                JSONStatusCode = int.Parse(response.Content.Substring(26, 3));
            }
            return response.Content;
        }

        public async Task<string> MakePostTokenRequest()
        {
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"token";
            request.AddJsonBody(new JObject {
            new JProperty("apiKey", APIKey)
            }.ToString());
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            if (StatusCode == 200)
            {
                JSONStatusCode = int.Parse(response.Content.Substring(26, 3));
            }
            return response.Content;
        }

    }
}
