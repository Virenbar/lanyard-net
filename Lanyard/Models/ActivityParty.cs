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

#if DEBUG

        [JsonProperty("size")]
        public ActivityPartySize Size { get; set; }

#endif
    }
}