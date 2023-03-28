using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Lanyard.Models
{
    public class Presence
    {
        [JsonProperty("active_on_discord_desktop")]
        public bool ActiveOnDiscordDesktop { get; internal set; }

        [JsonProperty("active_on_discord_mobile")]
        public bool ActiveOnDiscordMobile { get; internal set; }

        [JsonProperty("active_on_discord_web")]
        public bool ActiveOnDiscordWeb { get; internal set; }

        [JsonProperty("activities")]
        public List<Activity> Activities { get; internal set; }

        [JsonProperty("discord_status")]
        [JsonConverter(typeof(StringEnumConverter), typeof(CamelCaseNamingStrategy))]
        public Status DiscordStatus { get; internal set; }

        [JsonProperty("discord_user")]
        public DiscordUser DiscordUser { get; set; }

        [JsonProperty("kv")]
        public Dictionary<string, string> KV { get; internal set; }

        [JsonProperty("listening_to_spotify")]
        public bool ListeningToSpotify { get; internal set; }

        [JsonProperty("spotify")]
        public Spotify Spotify { get; set; }
    }
}