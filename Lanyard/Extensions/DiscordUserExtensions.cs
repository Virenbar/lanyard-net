using Lanyard.Models;

namespace Lanyard.Extensions
{
    public static class DiscordUserExtensions
    {
        private const string CDN_AVATAR = "https://cdn.discordapp.com/avatars";
        private const string CDN_AVATAR_DEFAULT = "https://cdn.discordapp.com/embed/avatars";

        /// <summary>
        /// Avatar URL
        /// </summary>
        public static string AvatarURL(this DiscordUser user) => AvatarURL(user, 512);

        /// <summary>
        /// Avatar URL
        /// </summary>
        /// <param name="user"></param>
        /// <param name="size">Avatar size</param>
        public static string AvatarURL(this DiscordUser user, int size)
        {
            if (user is null) { return null; }
            // Fall back avatar
            if (string.IsNullOrEmpty(user.Avatar))
            {
                return $"{CDN_AVATAR_DEFAULT}/{int.Parse(user.Discriminator) % 5}.png";
            }
            // Animated prefix
            if (user.Avatar.StartsWith("a_"))
            {
                return $"{CDN_AVATAR}/{user.ID}/{user.Avatar}.gif?size={size}";
            }
            return $"{CDN_AVATAR}/{user.ID}/{user.Avatar}.webp?size={size}";
        }

        public static string UserIconURL(this DiscordUser user) => UserIconURL(user, FileType.webp);

        public static string UserIconURL(this DiscordUser user, FileType type) => $"{Constants.QuickLinks}/{user.ID}.{type}";
    }
}