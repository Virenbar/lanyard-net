using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class Timestamps
    {
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Start { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; set; }
    }
}