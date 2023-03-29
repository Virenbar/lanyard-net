using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class Timestamps
    {
        /// <summary>
        /// Time of when the activity ends
        /// </summary>
        [JsonProperty("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? End { get; internal set; }

        /// <summary>
        /// Time of when the activity started
        /// </summary>
        [JsonProperty("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Start { get; internal set; }

        public override string ToString()
        {
            if (Start.HasValue && End.HasValue) { return $"{Start} - {End}"; }
            else if (Start.HasValue) { return $"{Start}"; }
            else if (End.HasValue) { return $"{End}"; }
            return "";
        }
    }
}