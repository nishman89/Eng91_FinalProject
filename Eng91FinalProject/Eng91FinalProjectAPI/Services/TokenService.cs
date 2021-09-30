using System;
using System.Threading.Tasks;
using Eng91FinalProjectAPI.Data;
using Eng91FinalProjectAPI.HTTPManager;
using Newtonsoft.Json.Linq;
using static Eng91FinalProjectAPI.Data.Model;

namespace Eng91FinalProjectAPI.Services
{
    public class TokenService : IService
    {
        public CallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<TokenResponse> TokenResponseDTO { get; set; }
        public DTO<ErrorResponse> ErrorResponseDTO { get; set; }
        public string RequestResponse { get; set; }

        public TokenService()
        {
            CallManager = new CallManager();
            ErrorResponseDTO = new DTO<ErrorResponse>();
            TokenResponseDTO = new DTO<TokenResponse>();
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
            if (CallManager.StatusCode == 400)
            {
                CallManager.JSONStatusCode = Int32.Parse(JsonResponse["status"].ToString());
            }
        }
    }
}
