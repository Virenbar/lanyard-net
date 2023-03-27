using Newtonsoft.Json;

namespace Lanyard.Models
{
    public class PresenceResponce : Responce
    {
        [JsonProperty("data")]
        public Presence Data { get; set; }
    }
}