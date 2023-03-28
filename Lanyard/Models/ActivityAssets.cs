using Newtonsoft.Json;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class ActivityAssets
    {
        [JsonProperty("large_image")]
        public string LargeImage { get; internal set; }

        [JsonProperty("large_text")]
        public string LargeText { get; internal set; }

        [JsonProperty("small_image")]
        public string SmallImage { get; internal set; }

        [JsonProperty("small_text")]
        public string SmallText { get; internal set; }
    }
}