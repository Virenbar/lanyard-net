using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class ActivityEmoji
    {
        [JsonProperty("animated")]
        public bool Animated { get; internal set; }

        [JsonProperty("id")]
        public string ID { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}