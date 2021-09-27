using Newtonsoft.Json;

namespace Eng91FinalProjectAPI.Data
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        public ResponseType Response { get; set; }

        public void Deserialize(string response)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(response);
        }
    }

}
