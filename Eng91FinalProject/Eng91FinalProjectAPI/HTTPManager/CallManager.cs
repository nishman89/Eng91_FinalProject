using APIMiniProject;
using RestSharp;
using System.Threading.Tasks;

namespace Eng91FinalProjectAPI.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;

        public int StatusCode { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public CallManager(string uri)
        {
            _client = new RestClient(uri);
        }

        public async Task<string> MakeTraineeRequestAsync()
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"/trainees";
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<string> MakeProfileRequestAsync()
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            request.Resource = $"/profiles";
            IRestResponse response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }
    }
}
