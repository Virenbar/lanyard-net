using Newtonsoft.Json;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class Activity
    {
        [JsonProperty("application_id")]
        public string ApplicationID { get; internal set; }

        [JsonProperty("assets")]
        public ActivityAssets Assets { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CreatedAt { get; internal set; }

        [JsonProperty("details")]
        public string Details { get; internal set; }

        [JsonProperty("emoji")]
        public ActivityEmoji Emoji { get; internal set; }

        [JsonProperty("flags")]
        public ActivityFlags? Flags { get; internal set; }

        [JsonProperty("id")]
        public string ID { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("party")]
        public ActivityParty Party { get; internal set; }

        [JsonProperty("session_id")]
        public string SessionID { get; internal set; }

        [JsonProperty("state")]
        public string State { get; internal set; }

        [JsonProperty("sync_id")]
        public string SyncID { get; internal set; }

        [JsonProperty("timestamps")]
        public Timestamps Timestamps { get; set; }

        [JsonProperty("type")]
        public ActivityType Type { get; internal set; }

        public override string ToString() => $"{Name} ({ID})";
    }
}