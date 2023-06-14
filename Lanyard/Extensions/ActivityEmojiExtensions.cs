using Lanyard.Models;
using System.Text;

namespace Lanyard.Extensions
{
    public static class ActivityEmojiExtensions
    {
        private const string CDN_EMOJI = "https://cdn.discordapp.com/emojis";
        private const string CDN_TWEMOJI = "https://cdn.jsdelivr.net/gh/twitter/twemoji/assets/72x72";
        private static readonly Dictionary<string, string> Overrides = new();

        static ActivityEmojiExtensions()
        {
            Overrides.Add("❤️", "2764");
        }

        /// <summary>
        /// Emoji URL
        /// </summary>
        public static string EmojiURL(this ActivityEmoji emoji)
        {
            if (string.IsNullOrEmpty(emoji.ID)) { return TwemojiURL(EncodedTwemoji(emoji.Name)); }
            return $"{CDN_EMOJI}/{emoji.ID}.{(emoji.Animated ? "gif" : "png")}?size = 64";
        }

        private static string EncodedTwemoji(string emoji)
        {
            if (Overrides.TryGetValue(emoji, out string twemoji)) { return twemoji; }
            // Cursed code
            // https://stackoverflow.com/a/32141922/9530839
            var bytes = Encoding.UTF32.GetBytes(emoji);
            var I = new int[bytes.Length / 4];
            Buffer.BlockCopy(bytes, 0, I, 0, bytes.Length);
            var hex = I.Select(C => $"{C:x}");
            return string.Join("-", hex);
        }

        private static string TwemojiURL(string emoji) => $"{CDN_TWEMOJI}/{emoji}.png";
    }
}