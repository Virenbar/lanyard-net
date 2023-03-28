using Lanyard.Models;

namespace Lanyard.Extensions
{
    public static class PresenceExtensions
    {
        public static Activity Activity(this Presence presence) => presence.Activities.FirstOrDefault();

        public static string AvatarURL(this Presence presence) => AvatarURL(presence, FileType.png);

        public static string AvatarURL(this Presence presence, FileType type)
        {
            return $"{Constants.DiscordCDN}{presence.DiscordUser.ID}/{presence.DiscordUser.Avatar}.{type}";
        }

        public static string UserIconURL(this Presence presence) => UserIconURL(presence, FileType.png);

        public static string UserIconURL(this Presence presence, FileType type)
        {
            return $"{Constants.QuickLinks}{presence.DiscordUser.ID}.{type}";
        }
    }
}