using Lanyard.Models;

namespace Lanyard.Extensions
{
    public static class SpotifyExtensions
    {
        /// <summary>
        /// Gets the duration of the song
        /// </summary>
        public static TimeSpan? Duration(this Spotify spotify) => spotify.Timestamps.End?.Subtract(spotify.Timestamps.Start);

        /// <summary>
        /// Gets the elapsed duration of the song
        /// </summary>
        public static TimeSpan? Elapsed(this Spotify spotify) => DateTimeOffset.UtcNow - spotify.Timestamps.Start;

        /// <summary>
        /// Gets the remaining duration of the song
        /// </summary>
        public static TimeSpan? Remaining(this Spotify spotify) => spotify.Timestamps.End - DateTimeOffset.UtcNow;
    }
}