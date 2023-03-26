using Lanyard.Models;

namespace Lanyard
{
    /// <summary>
    /// Lanyard client
    /// </summary>
    public class LanyardClient : BaseClient
    {
        protected const string EndPoint = "https://api.lanyard.rest/v1/";

        /// <summary>
        /// Creates new lanyard client with default endpoint
        /// </summary>
        public LanyardClient() : this(EndPoint) { }

        /// <summary>
        /// Creates new lanyard client with custom endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        public LanyardClient(string endpoint) : base(endpoint) { }

        /// <summary>
        /// Get data for user
        /// </summary>
        /// <param name="userID">Discord user ID</param>
        /// <returns></returns>
        public Task<UserResponce> User(string userID) => Get<UserResponce>($"users/{userID}");
    }
}