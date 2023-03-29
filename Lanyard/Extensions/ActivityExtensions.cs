using Lanyard.Models;

namespace Lanyard.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Activity"/>
    /// </summary>
    public static class ActivityExtensions
    {
        /// <summary>
        /// Duration of the activity
        /// </summary>
        public static TimeSpan? Elapsed(this Activity activity) => DateTime.UtcNow - activity.Timestamps.Start;

        /// <summary>
        /// URL of large image
        /// </summary>
        public static string LargeImageURL(this Activity activity) => LargeImageURL(activity, FileType.png);

        /// <summary>
        /// URL of large image
        /// </summary>
        public static string LargeImageURL(this Activity activity, FileType type)
        {
            return $"{Constants.DiscordCDN}app-assets/{activity.ApplicationID}/{activity.Assets?.LargeImage}.{type}";
        }

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
        public static string SmallImageURL(this Activity activity) => SmallImageURL(activity, FileType.png);

        /// <summary>
        /// URL of small image
        /// </summary>
        public static string SmallImageURL(this Activity activity, FileType type)
        {
            return $"{Constants.DiscordCDN}app-assets/{activity.ApplicationID}/{activity.Assets.SmallImage}.{type}";
        }

        /// <summary>
        /// Hover text of small image
        /// </summary>
        public static string SmallText(this Activity activity) => activity.Assets.SmallText;
    }
}