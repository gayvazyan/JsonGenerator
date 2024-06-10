using System;
using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(AssignmentOfAllRightsAndBenefits))]
[Description(nameof(AssignmentOfAllRightsAndBenefits))]
public class AssignmentOfAllRightsAndBenefits
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string MailAddress { get; set; }

    [Required]
    public string PayToTheOrderOf { get; set; }

    [Required]
    public string ClientName { get; set; }

    [Required]
    public string ClientSignatureUrl { get; set; }

    [Required]
    public DateTime ClientSignatureDate { get; set; }

    [Required]
    public string ParentGuardianConservatorName { get; set; }

    [Required]
    public string ParentGuardianConservatorSignatureUrl { get; set; }

    [Required]
    public DateTime ParentGuardianConservatorSignatureDate { get; set; }

    [Required]
    public string GuarantorName { get; set; }

    [Required]
    public string GuarantorSignatureUrl { get; set; }

    [Required]
    public DateTime GuarantorSignatureDate { get; set; }
}