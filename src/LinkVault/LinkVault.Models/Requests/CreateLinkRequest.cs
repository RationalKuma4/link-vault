using System.Diagnostics.CodeAnalysis;

namespace LinkVault.Models.Requests;

[ExcludeFromCodeCoverage]
public class CreateLinkRequest
{
    public string? Category { get; set; }
    public string? Source { get; set; }
    public string? Link { get; set; }
    public string? Status { get; set; }
    public IEnumerable<string>? Tags { get; set; }
}