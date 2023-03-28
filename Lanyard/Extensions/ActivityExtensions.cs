using Lanyard.Models;

namespace Lanyard.Extensions
{
    public static class ActivityExtensions
    {
        public static string LargeImageURL(this Activity activity) => LargeImageURL(activity, FileType.png);

        public static string LargeImageURL(this Activity activity, FileType type)
        {
            return $"{Constants.DiscordCDN}app-assets/{activity.ApplicationID}/{activity.Assets.LargeImage}.{type}";
        }

        public static string LargeText(this Activity activity) => activity.Assets.LargeText;

        public static string SmallImageURL(this Activity activity) => SmallImageURL(activity, FileType.png);

        public static string SmallImageURL(this Activity activity, FileType type)
        {
            return $"{Constants.DiscordCDN}app-assets/{activity.ApplicationID}/{activity.Assets.SmallImage}.{type}";
        }

        public static string SmallText(this Activity activity) => activity.Assets.SmallText;
    }
}