using Lanyard.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace Lanyard.Models
{
    [TypeConverter(typeof(SerializableExpandableObjectConverter))]
    public class Spotify
    {
        [JsonProperty("album")]
        public string Album { get; internal set; }

        [JsonProperty("album_art_url")]
        public Uri AlbumArtURL { get; internal set; }

        [JsonProperty("artist")]
        public string Artist { get; internal set; }

        [JsonProperty("song")]
        public string Song { get; internal set; }

        [JsonProperty("timestamps")]
        public Timestamps Timestamps { get; set; }

        [JsonProperty("track_id")]
        public string TrackID { get; internal set; }

        public override string ToString() => $"{Artist} - {Song} ({this.Duration():HH:mm:ss})";
    }
}