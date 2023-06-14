using Lanyard.Models;

namespace Lanyard.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Activity"/>
    /// </summary>
    public static class ActivityExtensions
    {
        private const string APP_ICON = "https://dcdn.dstn.to/app-icons";
        private const string CDN_ASSET = "https://cdn.discordapp.com/app-assets";
        private const string CDN_MEDIA = "https://media.discordapp.net";
        private const string SPOTIFY = "https://i.scdn.co/image";

        /// <summary>
        /// Activity asset URL
        /// </summary>
        public static string AssetURL(this Activity activity, AssetType type)
        {
            if (activity is null) { return null; }

            if (activity.Type == ActivityType.CustomStatus)
            {
                return activity.Emoji.EmojiURL();
            }
            if (activity.Assets is null) { return null; }

            var smallImage = activity.Assets.SmallImage;
            var largeImage = activity.Assets.LargeImage ?? (activity.ID.StartsWith("spotify:") ? activity.ID : null);
            var asset = type == AssetType.Small ? smallImage : largeImage;
            return AssetURL(activity.ApplicationID, asset);
        }

        /// <summary>
        /// Duration of the activity
        /// </summary>
        public static TimeSpan? Elapsed(this Activity activity) => DateTime.UtcNow - activity.Timestamps.Start;

        /// <summary>
        /// URL of large image
        /// </summary>
        public static string LargeImageURL(this Activity activity) => activity.AssetURL(AssetType.Large);

        /// <summary>
        /// Hover text of large image
        /// </summary>
        public static string LargeText(this Activity activity) => activity.Assets.LargeText;

        /// <summary>
        /// Current size of the party
        /// </summary>
        public static int? PartyCurrentSize(this Activity activity) => activity.Party?.Size?.FirstOrDefault();

        /// <summary>
        /// Maximum size of the party
        /// </summary>
        public static int? PartyMaxSize(this Activity activity) => activity.Party?.Size?.LastOrDefault();

        /// <summary>
        /// URL of small image
        /// </summary>
        public static string SmallImageURL(this Activity activity) => activity.AssetURL(AssetType.Small);

        /// <summary>
        /// Hover text of small image
        /// </summary>
        public static string SmallText(this Activity activity) => activity.Assets.SmallText;

        private static string AssetURL(string applicationID, string asset)
        {
            if (applicationID is null && asset is null) { return null; }
            if (applicationID is not null && asset is null) { return $"{APP_ICON}/{applicationID}.webp?size=512"; }
            if (asset is null) { return null; }

            var split = asset.Split(':');
            if (split.Length > 1)
            {
                var prefix = split[0];
                var id = split[1];
                if (prefix == "spotify")
                {
                    if (id == "1") { return null; }
                    // Spotify asset
                    return $"{SPOTIFY}/{id}";
                }
                else if (prefix == "mp")
                {
                    // External asset
                    return $"{CDN_MEDIA}/{id}";
                }
                else
                {
                    return null;
                }
            }
            // Application asset
            return $"{CDN_ASSET}/{applicationID}/{asset}.webp?size=512";
        }
    }
}