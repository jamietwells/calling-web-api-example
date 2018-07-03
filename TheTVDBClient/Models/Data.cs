using Newtonsoft.Json;

namespace TheTVDBClient.Models
{
    public class Data
    {
        [JsonProperty("absoluteNumber")]
        public long AbsoluteNumber { get; set; }

        [JsonProperty("airedEpisodeNumber")]
        public long AiredEpisodeNumber { get; set; }

        [JsonProperty("airedSeason")]
        public long AiredSeason { get; set; }

        [JsonProperty("airsAfterSeason")]
        public long AirsAfterSeason { get; set; }

        [JsonProperty("airsBeforeEpisode")]
        public long AirsBeforeEpisode { get; set; }

        [JsonProperty("airsBeforeSeason")]
        public long AirsBeforeSeason { get; set; }

        [JsonProperty("director")]
        public string Director { get; set; }

        [JsonProperty("directors")]
        public string[] Directors { get; set; }

        [JsonProperty("dvdChapter")]
        public long DvdChapter { get; set; }

        [JsonProperty("dvdDiscid")]
        public string DvdDiscid { get; set; }

        [JsonProperty("dvdEpisodeNumber")]
        public long DvdEpisodeNumber { get; set; }

        [JsonProperty("dvdSeason")]
        public long DvdSeason { get; set; }

        [JsonProperty("episodeName")]
        public string EpisodeName { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("firstAired")]
        public string FirstAired { get; set; }

        [JsonProperty("guestStars")]
        public string[] GuestStars { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("imdbId")]
        public string ImdbId { get; set; }

        [JsonProperty("lastUpdated")]
        public long LastUpdated { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("productionCode")]
        public string ProductionCode { get; set; }

        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }

        [JsonProperty("showUrl")]
        public string ShowUrl { get; set; }

        [JsonProperty("siteRating")]
        public long SiteRating { get; set; }

        [JsonProperty("siteRatingCount")]
        public long SiteRatingCount { get; set; }

        [JsonProperty("thumbAdded")]
        public string ThumbAdded { get; set; }

        [JsonProperty("thumbAuthor")]
        public long ThumbAuthor { get; set; }

        [JsonProperty("thumbHeight")]
        public string ThumbHeight { get; set; }

        [JsonProperty("thumbWidth")]
        public string ThumbWidth { get; set; }

        [JsonProperty("writers")]
        public string[] Writers { get; set; }
    }
}