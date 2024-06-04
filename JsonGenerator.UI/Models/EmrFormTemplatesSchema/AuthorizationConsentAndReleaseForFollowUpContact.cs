using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(AuthorizationConsentAndReleaseForFollowUpContact))]
[Description(nameof(AuthorizationConsentAndReleaseForFollowUpContact))]
public class AuthorizationConsentAndReleaseForFollowUpContact
{
    [Required]
    public string ClientName { get; set; }

    [Required]
    public string LegalNameOfProvider { get; set; }

    [Required]
    public string PreferredMailingAddress { get; set; }

    [Required]
    public string PreferredEmailAddress { get; set; }

    [Required]
    public string PreferredTelephoneNumber { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string ClientOrParentGuardianConservatorSignatureUrl { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public string ParentGuardianConservatorDescribeAuthorityToAct { get; set; }
}