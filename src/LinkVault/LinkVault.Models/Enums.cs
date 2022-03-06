using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace LinkVault.Models;

[ExcludeFromCodeCoverage]
internal class Enums
{
    public enum HealthStatus
    {
        Healthy = 0,
        RequestTimeout = 1,
        Unhealthy = 2
    }

    public enum QaHeaders
    {
        [Description("DynamoDb")]
        DynamoDb
    }
}