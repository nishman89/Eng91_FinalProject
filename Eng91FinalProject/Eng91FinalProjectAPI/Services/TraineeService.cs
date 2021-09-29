using System.Threading.Tasks;
using Eng91FinalProjectAPI.Data;
using Eng91FinalProjectAPI.HTTPManager;
using Newtonsoft.Json.Linq;
using static Eng91FinalProjectAPI.Data.Model;

namespace Eng91FinalProjectAPI.Services
{
    public class TraineeService
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<TraineeResponse> TraineeResponseDTO { get; set; }
        public DTO<TokenResponse> TokenResponseDTO { get; set; }
        public DTO<ErrorResponse> ErrorResponseDTO { get; set; }
        public string RequestResponse { get; set; }

        public TraineeService()
        {
            CallManager = new CallManager();
            TraineeResponseDTO = new DTO<TraineeResponse>();
            ErrorResponseDTO = new DTO<ErrorResponse>();
            TokenResponseDTO = new DTO<TokenResponse>();
        }

        public async Task MakeTraineeRequestAsync()
        {
            RequestResponse = await CallManager.MakeGetRequestAsync(CallManager.GetMethods.Trainees);
            JsonResponse = JObject.Parse(RequestResponse);
            ParseProfileObject();
        }

        public async Task MakeProfileRequestAsync()
        {
            RequestResponse = await CallManager.MakeGetRequestAsync(CallManager.GetMethods.Profiles);
            JsonResponse = JObject.Parse(RequestResponse);
            ParseProfileObject();
        }

        public async Task MakeTokenRequestAsync()
        {
            RequestResponse = await CallManager.MakePostTokenRequest();
            JsonResponse = JObject.Parse(RequestResponse);
            ParseTokenObject();
        }

        private void ParseTokenObject()
        {
            if (CallManager.StatusCode == 200)
            {
                TokenResponseDTO.Deserialize(RequestResponse);
            }
        }

        private void ParseProfileObject()
        {
            if (CallManager.JSONStatusCode == 200)
            {
                TraineeResponseDTO.Deserialize(RequestResponse);
            }
            if (CallManager.JSONStatusCode == 400)
            {
                ErrorResponseDTO.Deserialize(RequestResponse);
            }
        }
    }
}
