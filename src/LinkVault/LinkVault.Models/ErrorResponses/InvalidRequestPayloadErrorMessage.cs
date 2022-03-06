using System.Diagnostics.CodeAnalysis;

namespace LinkVault.Models.ErrorResponses;

[ExcludeFromCodeCoverage, Serializable]
public class InvalidRequestPayloadErrorMessage : ErrorResponse
{
    public override string? Error => "400#requestPayload";
    public override string? Message => "Invalid request payload";
    public override string? MoreInfo => Constants.TemplateRequest.ErrorCodeReferenceUrl + Error;
}