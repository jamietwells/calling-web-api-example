using Newtonsoft.Json;
namespace TheTVDBClient.Models
{
    public class Errors
    {
        [JsonProperty("invalidFilters")]
        public string[] InvalidFilters { get; set; }

        [JsonProperty("invalidLanguage")]
        public string InvalidLanguage { get; set; }

        [JsonProperty("invalidQueryParams")]
        public string[] InvalidQueryParams { get; set; }
    }
}