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
        public string RequestResponse { get; set; }

        public TraineeService()
        {
            CallManager = new CallManager();
            TraineeResponseDTO = new DTO<TraineeResponse>();
        }

        public async Task MakeTraineeRequestAsync()
        {
            RequestResponse = await CallManager.MakeGetRequestAsync(CallManager.GetMethods.Trainees);
            ParseObjects();
        }

        public async Task MakeProfileRequestAsync()
        {
            RequestResponse = await CallManager.MakeGetRequestAsync(CallManager.GetMethods.Profiles);
            ParseObjects();
        }

        private void ParseObjects()
        {
            if (CallManager.StatusCode == 200)
            {
                JsonResponse = JObject.Parse(RequestResponse);
                TraineeResponseDTO.Deserialize(RequestResponse);
            }
        }
    }
}
