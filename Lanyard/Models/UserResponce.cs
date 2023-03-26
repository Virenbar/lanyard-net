using Newtonsoft.Json;

namespace Lanyard.Models
{
    public class UserResponce : Responce
    {
        [JsonProperty("data")]
        public Presence Data { get; set; }
    }
}