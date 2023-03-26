using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class Spotify
    {
        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("album_art_url")]
        public Uri AlbumArtURL { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("song")]
        public string Song { get; set; }

        [JsonProperty("timestamps")]
        public Timestamps Timestamps { get; set; }

        [JsonProperty("track_id")]
        public string TrackID { get; set; }
    }
}