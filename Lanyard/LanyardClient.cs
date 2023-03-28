using Lanyard.Exceptions;
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
        /// <returns><see cref="Presence"/></returns>
        /// <exception cref="LanyardException"/>
        public async Task<Presence> GetPresence(string userID)
        {
            var Responce = await Get<PresenceResponce>($"users/{userID}");
            if (!Responce.Success) { throw new LanyardException(Responce.Error); }
            return Responce.Data;
        }
    }
}