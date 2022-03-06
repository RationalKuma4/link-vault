using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace LinkVault.Models.Tables;

[ExcludeFromCodeCoverage]
public class LinkVaultTable
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }
}