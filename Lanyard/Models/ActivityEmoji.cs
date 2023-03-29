using Newtonsoft.Json;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class ActivityEmoji
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}