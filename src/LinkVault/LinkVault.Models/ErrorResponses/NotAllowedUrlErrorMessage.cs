using System.Diagnostics.CodeAnalysis;

namespace LinkVault.Models.ErrorResponses;

[ExcludeFromCodeCoverage, Serializable]
public class NotAllowedUrlErrorMessage : ErrorResponse
{
    public override string? Error => "400#urlNotAllowed";
    public override string? Message => "The url is not allowed";
    public override string? MoreInfo => Constants.TemplateRequest.ErrorCodeReferenceUrl + Error;
}