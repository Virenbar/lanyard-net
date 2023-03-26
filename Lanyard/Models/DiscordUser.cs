using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class DiscordUser
    {
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("discriminator")]
        public string Discriminator { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("public_flags")]
        public long PublicFlags { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}