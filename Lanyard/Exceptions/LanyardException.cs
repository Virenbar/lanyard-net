using Lanyard.Models;

namespace Lanyard.Exceptions
{
    /// <summary>
    /// Lanyard API exception
    /// </summary>
    public class LanyardException : Exception
    {
        internal LanyardException(ResponceError error) : base(error.Message)
        {
            Error = error;
        }

        /// <summary>
        /// Error Responce
        /// </summary>
        public ResponceError Error { get; }
    }
}