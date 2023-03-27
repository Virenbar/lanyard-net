using Lanyard.Models;

namespace Lanyard
{
    /// <summary>
    /// Lanyard KV client
    /// </summary>
    public class KVClient : BaseClient
    {
        private readonly string UserID;

        /// <summary>
        /// Creates new KV client with custom endpoint
        /// </summary>
        /// <param name="userID">Discord user ID</param>
        /// <param name="APIKey">API Key</param>
        /// <param name="endpoint">Endpoint</param>
        public KVClient(string userID, string APIKey, string endpoint) : base(endpoint)
        {
            UserID = userID;
            Client.DefaultRequestHeaders.Add("Authorization", APIKey);
        }

        /// <summary>
        /// Creates new KV client with default endpoint
        /// </summary>
        /// <param name="userID">Discord user ID</param>
        /// <param name="APIKey">API Key</param>
        public KVClient(string userID, string APIKey) : this(userID, APIKey, Constants.EndPoint) { }

        /// <summary>
        /// Get presence for user
        /// </summary>
        public Task<PresenceResponce> GetPresence() => Get<PresenceResponce>($"users/{UserID}");

        #region KV

        /// <summary>
        /// Delete key from KV
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Task DeleteKey(string key) => Delete($"users/{UserID}/kv/{key}");

        /// <summary>
        /// Set key in KV
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Task SetKey(string key, string value) => Put($"users/{UserID}/kv/{key}", value);

#if NETCOREAPP

        /// <summary>
        /// Set multiple keys in KV
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public Task SetKeys(IDictionary<string, string> values) => Patch($"users/{UserID}/kv/", values);

#endif
        #endregion KV
    }
}