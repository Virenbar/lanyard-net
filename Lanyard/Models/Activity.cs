using Newtonsoft.Json;

namespace Lanyard.Models
{
    public class Activity
    {
        [JsonProperty("application_id")]
        public string ApplicationID { get; set; }

        [JsonProperty("assets")]
        public Assets Assets { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("flags")]
        public long? Flags { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public Party Party { get; set; }

        [JsonProperty("session_id")]
        public string SessionID { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("sync_id")]
        public string SyncID { get; set; }

        [JsonProperty("timestamps")]
        public Timestamps Timestamps { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }
    }
}