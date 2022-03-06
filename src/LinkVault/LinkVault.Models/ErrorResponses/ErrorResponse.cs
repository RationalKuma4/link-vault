using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace LinkVault.Models.ErrorResponses;

[Serializable, ExcludeFromCodeCoverage]
public class ErrorResponse
{
    [JsonPropertyName("error")]
    public virtual string? Error { get; set; }

    [JsonPropertyName("message")]
    public virtual string? Message { get; set; }

    [JsonPropertyName("moreInfo")]
    public virtual string? MoreInfo { get; set; }
}