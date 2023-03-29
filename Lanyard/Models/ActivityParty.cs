using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class ActivityParty
    {
        [JsonProperty("id")]
        public string ID { get; internal set; }

        [JsonProperty("size")]
        public int[] Size { get; internal set; }

        public override string ToString() => $"{ID}{(Size is null ? "": $"({Size[0]}/{Size[1]})")}";
    }
}