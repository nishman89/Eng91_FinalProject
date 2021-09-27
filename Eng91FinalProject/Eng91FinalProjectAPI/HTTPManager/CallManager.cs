using APIMiniProject;
using RestSharp;
using System.Threading.Tasks;

namespace Eng91FinalProjectAPI.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;

        public int StatusCode { get; set; }
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
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

    }
}
