namespace Lanyard
{
    /// <summary>
    /// Discord user flags
    /// </summary>
    [Flags]
    public enum UserFlags
    {
        /// <summary>
        /// Discord Employee
        /// </summary>
        STAFF = 1 << 0,

        /// <summary>
        /// Partnered Server Owner
        /// </summary>
        PARTNER = 1 << 1,

        /// <summary>
        /// HypeSquad Events Member
        /// </summary>
        HYPESQUAD = 1 << 2,

        /// <summary>
        /// Bug Hunter Level 1
        /// </summary>
        BUG_HUNTER_LEVEL_1 = 1 << 3,

        /// <summary>
        /// House Bravery Member
        /// </summary>
        HYPESQUAD_ONLINE_HOUSE_1 = 1 << 6,

        /// <summary>
        /// House Brilliance Member
        /// </summary>
        HYPESQUAD_ONLINE_HOUSE_2 = 1 << 7,

        /// <summary>
        /// House Balance Member
        /// </summary>
        HYPESQUAD_ONLINE_HOUSE_3 = 1 << 8,

        /// <summary>
        /// Early Nitro Supporter
        /// </summary>
        PREMIUM_EARLY_SUPPORTER = 1 << 9,

        /// <summary>
        /// User is a team
        /// </summary>
        TEAM_PSEUDO_USER = 1 << 10,

        /// <summary>
        ///  Bug Hunter Level 2
        /// </summary>
        BUG_HUNTER_LEVEL_2 = 1 << 14,

        /// <summary>
        /// Verified Bot
        /// </summary>
        VERIFIED_BOT = 1 << 16,

        /// <summary>
        /// Early Verified Bot Developer
        /// </summary>
        VERIFIED_DEVELOPER = 1 << 17,

        /// <summary>
        /// Moderator Programs Alumni
        /// </summary>
        CERTIFIED_MODERATOR = 1 << 18,

        /// <summary>
        /// Bot uses only HTTP interactions and is shown in the online member list
        /// </summary>
        BOT_HTTP_INTERACTIONS = 1 << 19,

        /// <summary>
        /// User is an Active Developer
        /// </summary>
        ACTIVE_DEVELOPER = 1 << 22
    }
}