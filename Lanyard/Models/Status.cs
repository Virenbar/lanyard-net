using System.Runtime.Serialization;

namespace Lanyard.Models
{
    /// <summary>
    /// User status
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Offline
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline,

        /// <summary>
        /// Do not disturb
        /// </summary>
        [EnumMember(Value = "dnd")]
        DND,

        /// <summary>
        /// Idle
        /// </summary>
        [EnumMember(Value = "idle")]
        Idle,

        /// <summary>
        /// Online
        /// </summary>
        [EnumMember(Value = "online")]
        Online
    }
}