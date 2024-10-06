using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace ASCOM
{
    /// <summary>
    /// All methods defined by the relevant ASCOM standard interface must exist in each driver. However, those methods do not all have to be <i>implemented</i>. The minimum requirement
    /// for each defined method is to throw the ASCOM.MethodNotImplementedException. Note that no default constructor is supplied. Throwing this requires the the method name.
    /// </summary>
    /// <remarks>
    /// <para>If you need to throw this error as a COM exception use the error number: 0x80040400.</para>
    /// </remarks>

    [Serializable]
    [ComVisible(true)]
    [Guid("BBED286E-5814-4467-9471-A499DED13452")]
    public class MethodNotImplementedException : NotImplementedException
    {
        [NonSerialized] const string csMessage = "Method {0}";
        [NonSerialized] readonly string method = "Unknown";

        /// <summary>
        /// Create a new exception object and identify the specified driver method as the source.
        /// </summary>
        /// <param name = "method">The name of the driver method that caused the exception.</param>
        public MethodNotImplementedException(string method) : base(String.Format(CultureInfo.InvariantCulture, csMessage, method))
        {
            this.method = method;
        }

        /// <summary>
        /// Create a new exception with the supplied message
        /// </summary>
        /// <param name = "method">Method name</param>
        /// <param name = "message">Exception description</param>
        /// <remarks>
        /// This overload applies the supplied message directly to the exception without interpreting it as is the case with other overloads
        /// </remarks>
        public MethodNotImplementedException(string method, string message) : base(method, message)
        {
            this.method = method;
        }

        /// <summary>
        /// Create a new exception object and identify the specified driver method as the source,
        /// and include an inner exception object containing a caught exception.
        /// </summary>
        /// <param name = "method">The name of the driver method that caused the exception</param>
        /// <param name = "inner">The caught exception</param>
        public MethodNotImplementedException(string method, Exception inner) : base(String.Format(CultureInfo.InvariantCulture, csMessage, method), inner)
        {
            this.method = method;
        }

        /// <summary>
        /// For Code Analysis, please don't use
        /// </summary>
        public MethodNotImplementedException() : base("UnknownMethod")
        {
        }
    }
}