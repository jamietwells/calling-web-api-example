using Newtonsoft.Json;

namespace TheTVDBClient.Models
{

    public class Episode
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("errors")]
        public Errors Errors { get; set; }
    }

}