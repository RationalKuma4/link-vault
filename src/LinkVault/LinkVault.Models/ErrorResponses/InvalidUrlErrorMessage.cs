using System.Diagnostics.CodeAnalysis;

namespace LinkVault.Models.ErrorResponses;

[ExcludeFromCodeCoverage, Serializable]
public class InvalidUrlErrorMessage : ErrorResponse
{
    public override string? Error => "400#url";
    public override string? Message => "The url must be supplied";
    public override string? MoreInfo => Constants.TemplateRequest.ErrorCodeReferenceUrl + Error;
}