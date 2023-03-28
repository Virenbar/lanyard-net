using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class DiscordUser
    {
        [JsonProperty("avatar")]
        public string Avatar { get; internal set; }

        [JsonProperty("discriminator")]
        public string Discriminator { get; internal set; }

        [JsonProperty("id")]
        public string ID { get; internal set; }

        [JsonProperty("public_flags")]
        public UserFlags PublicFlags { get; internal set; }

        [JsonProperty("username")]
        public string Username { get; internal set; }
    }
}