using Lanyard.Models;

namespace Lanyard.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Spotify"/>
    /// </summary>
    public static class SpotifyExtensions
    {
        /// <summary>
        /// Duration of the song
        /// </summary>
        public static TimeSpan? Duration(this Spotify spotify) => spotify.Timestamps.End?.Subtract(spotify.Timestamps.Start.Value);

        /// <summary>
        /// Elapsed duration of the song
        /// </summary>
        public static TimeSpan? Elapsed(this Spotify spotify) => DateTime.UtcNow - spotify.Timestamps.Start;

        /// <summary>
        /// Remaining duration of the song
        /// </summary>
        public static TimeSpan? Remaining(this Spotify spotify) => spotify.Timestamps.End - DateTime.UtcNow;

        /// <summary>
        /// URL of the song
        /// </summary>
        public static string TrackURL(this Spotify spotify) => $"https://open.spotify.com/track/{spotify.TrackID}";
    }
}