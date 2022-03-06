using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace LinkVault.Models.Exceptions;

[ExcludeFromCodeCoverage, Serializable]
public class DynamoException : Exception
{
    public DynamoException() { }
    public DynamoException(string message) : base(message) { }
    public DynamoException(string message, Exception innerException) : base(message, innerException) { }
    public DynamoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}