using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace LinkVault.Models.Exceptions;
[ExcludeFromCodeCoverage, Serializable]
public class NoRetryException : Exception
{
    public NoRetryException() { }
    public NoRetryException(string message) : base(message) { }
    public NoRetryException(string message, Exception innerException) : base(message, innerException) { }
    public NoRetryException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}