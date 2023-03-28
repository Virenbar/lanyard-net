using Lanyard.Exceptions;
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
        /// Get presence
        /// </summary>
        /// <returns><see cref="Presence"/></returns>
        /// <exception cref="LanyardException"/>
        public async Task<Presence> GetPresence()
        {
            var Responce = await Get<PresenceResponce>($"users/{UserID}");
            if (!Responce.Success) { throw new LanyardException(Responce.Error); }
            return Responce.Data;
        }

        #region KV

        /// <summary>
        /// Delete key from KV
        /// </summary>
        /// <param name="key"></param>
        public Task DeleteKey(string key) => Delete($"users/{UserID}/kv/{key}");

        /// <summary>
        /// Set key in KV
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Task SetKey(string key, string value) => Put($"users/{UserID}/kv/{key}", value);

#if NETCOREAPP

        /// <summary>
        /// Set multiple keys in KV
        /// </summary>
        /// <param name="values"></param>
        public Task SetKeys(IDictionary<string, string> values) => Patch($"users/{UserID}/kv/", values);

#endif
        #endregion KV
    }
}