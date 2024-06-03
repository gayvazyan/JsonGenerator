using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(ClientFinancialResponsibilityTalkingPoints))]
[Description(nameof(ClientFinancialResponsibilityTalkingPoints))]
public class ClientFinancialResponsibilityTalkingPoints
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string InsuranceCoverage { get; set; }

    [Required]
    public string SlidingScaleFeeAssistanceProgramDiscount { get; set; }
}