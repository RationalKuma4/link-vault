using System.Diagnostics.CodeAnalysis;

namespace LinkVault.Models;

[ExcludeFromCodeCoverage]
internal static class Constants
{
    public static class TemplateRequest
    {
        public const string ErrorCodeReferenceUrl = "https://developer.backgroundcheck.com/errors/id-verifications";
        public const string Api = "link-valut";
    }

    public static class HeaderKey
    {
        public const string RequestId = "Request-Id";
        public const string RetryAfter = "Retry-After";
    }

    public static class Health
    {
        public const string DynamoHealthCheckGuid = "c3f3f784-5f6b-4ab1-a461-0b47ae549c66";
    }
}