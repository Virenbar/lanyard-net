using Lanyard.Models;

namespace Lanyard.Extensions
{
    /// <summary>
    /// Extensions for <see cref="Presence"/>
    /// </summary>
    public static class PresenceExtensions
    {
        /// <summary>
        /// First activity
        /// </summary>
        public static Activity Activity(this Presence presence) => presence.Activities.FirstOrDefault();

        /// <summary>
        /// Avatar URL
        /// </summary>
        public static string AvatarURL(this Presence presence) => presence.DiscordUser.AvatarURL();

        /// <summary>
        /// Avatar URL
        /// </summary>
        /// <param name="presence"></param>
        /// <param name="size">Avatar size</param>
        public static string AvatarURL(this Presence presence, int size) => presence.DiscordUser.AvatarURL(size);

        public static string UserIconURL(this Presence presence) => presence.DiscordUser.UserIconURL();

        public static string UserIconURL(this Presence presence, FileType type) => presence.DiscordUser.UserIconURL(type);
    }
}