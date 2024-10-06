using System;

namespace ASCOM.Utilities.Exceptions
{
    [Serializable]
    internal class RestrictedAccessException : Exception
    {
        public RestrictedAccessException()
        {
        }

        public RestrictedAccessException(string message) : base(message)
        {
        }

        public RestrictedAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}