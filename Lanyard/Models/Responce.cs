using Newtonsoft.Json;

namespace Lanyard.Models
{
    public class Responce
    {
        [JsonProperty("error")]
        public ResponceError Error { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
    public class ResponceError
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}