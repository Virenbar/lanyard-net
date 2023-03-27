using Lanyard.Models;

namespace Lanyard
{
    /// <summary>
    /// Lanyard client
    /// </summary>
    public class LanyardClient : BaseClient
    {
        /// <summary>
        /// Creates new lanyard client with default endpoint
        /// </summary>
        public LanyardClient() : this(Constants.EndPoint) { }

        /// <summary>
        /// Creates new lanyard client with custom endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        public LanyardClient(string endpoint) : base(endpoint) { }

        /// <summary>
        /// Get presence for user
        /// </summary>
        /// <param name="userID">Discord user ID</param>
        /// <returns></returns>
        public Task<PresenceResponce> GetPresence(string userID) => Get<PresenceResponce>($"users/{userID}");
    }
}