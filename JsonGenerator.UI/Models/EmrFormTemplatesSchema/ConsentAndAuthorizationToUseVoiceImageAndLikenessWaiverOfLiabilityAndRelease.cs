using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(ConsentAndAuthorizationToUseVoiceImageAndLikenessWaiverOfLiabilityAndRelease))]
[Description(nameof(ConsentAndAuthorizationToUseVoiceImageAndLikenessWaiverOfLiabilityAndRelease))]
public class ConsentAndAuthorizationToUseVoiceImageAndLikenessWaiverOfLiabilityAndRelease
{
    [Required]
    public string ClientName { get; set; }

    [Required]
    public string LegalNameOfProvider { get; set; }

    [Required]
    public string ClientOrParentGuardianConservatorSignatureUrl { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public string ParentGuardianConservatorDescribeAuthorityToAct { get; set; }
}