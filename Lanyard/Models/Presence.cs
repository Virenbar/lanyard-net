using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Lanyard.Models
{
    public class Presence
    {
        [JsonProperty("active_on_discord_desktop")]
        public bool ActiveOnDiscordDesktop { get; set; }

        [JsonProperty("active_on_discord_mobile")]
        public bool ActiveOnDiscordMobile { get; set; }

        [JsonProperty("active_on_discord_web")]
        public bool ActiveOnDiscordWeb { get; set; }

        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }

        [JsonProperty("discord_status")]
        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public Status DiscordStatus { get; set; }

        [JsonProperty("discord_user")]
        public DiscordUser DiscordUser { get; set; }

        [JsonProperty("kv")]
        public Dictionary<string, string> KV { get; set; }

        [JsonProperty("listening_to_spotify")]
        public bool ListeningToSpotify { get; set; }

        [JsonProperty("spotify")]
        public Spotify Spotify { get; set; }
    }
}