using Lanyard.Models;

namespace Lanyard
{
    /// <summary>
    /// Lanyard KV client
    /// </summary>
    public class KVClient : LanyardClient
    {
        // private const string EndPoint = "https://api.lanyard.rest/v1/";

        private readonly string UserID;
        //private string APIKey;

        /// <summary>
        /// Creates new KV client with custom endpoint
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="APIKey"></param>
        /// <param name="endpoint">Endpoint</param>
        public KVClient(string userID, string APIKey, string endpoint) : base(endpoint)
        {
            UserID = userID;
            Client.DefaultRequestHeaders.Add("Authorization", APIKey);
        }

        /// <summary>
        /// Creates new KV client with default endpoint
        /// </summary>
        public KVClient(string userID, string APIKey) : this(userID, APIKey, EndPoint) { }

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

        public Task<UserResponce> User() => User(UserID);

        //private new Task<UserResponce> User(string userID) => base.User(userID);
    }
}