using Newtonsoft.Json;

namespace TheTVDBClient.Models
{
    public class Login
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

}