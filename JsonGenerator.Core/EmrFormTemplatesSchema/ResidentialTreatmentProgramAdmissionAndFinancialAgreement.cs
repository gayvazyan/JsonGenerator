using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(ResidentialTreatmentProgramAdmissionAndFinancialAgreement))]
[Description(nameof(ResidentialTreatmentProgramAdmissionAndFinancialAgreement))]
public class ResidentialTreatmentProgramAdmissionAndFinancialAgreement
{
    [Required]
    public string LegalNameOfProvider { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string NameOfProgram { get; set; }
}