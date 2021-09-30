using System;
using System.Threading.Tasks;
using Eng91FinalProjectAPI.Data;
using Eng91FinalProjectAPI.HTTPManager;
using Newtonsoft.Json.Linq;
using static Eng91FinalProjectAPI.Data.Model;

namespace Eng91FinalProjectAPI.Services
{
    public class TraineeService : IService
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<TraineeResponse> TraineeResponseDTO { get; set; }
        public DTO<ErrorResponse> ErrorResponseDTO { get; set; }
        public string RequestResponse { get; set; }

        public TraineeService()
        {
            CallManager = new CallManager();
            TraineeResponseDTO = new DTO<TraineeResponse>();
            ErrorResponseDTO = new DTO<ErrorResponse>();
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
