using System;
using System.Threading.Tasks;
using Eng91FinalProjectAPI.Data;
using Eng91FinalProjectAPI.HTTPManager;
using Newtonsoft.Json.Linq;
using static Eng91FinalProjectAPI.Data.Model;

namespace Eng91FinalProjectAPI.Services
{
    public interface IService
    {
        CallManager CallManager { get; set; }
        JObject JsonResponse { get; set; }
        string RequestResponse { get; set; }
        DTO<ErrorResponse> ErrorResponseDTO { get; set; }

    }
}
