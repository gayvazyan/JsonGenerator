using System;
using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(OutpatientTreatmentProgramAdmissionAndFinancialAgreement))]
[Description(nameof(OutpatientTreatmentProgramAdmissionAndFinancialAgreement))]
public class OutpatientTreatmentProgramAdmissionAndFinancialAgreement
{
    [Required]
    public string NameOfTheProgram { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string Activities { get; set; }

    [Required]
    public decimal Phpfee { get; set; }

    [Required]
    public decimal Iopfee { get; set; }

    [Required]
    public decimal Opfee { get; set; }

    [Required]
    public string InsuranceCompanies { get; set; }


    [Required]
    public string ClientInitials { get; set; }

    [Required]
    public string GuarantorInitials { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string ClientName { get; set; }

    [Required]
    public string GuarantorName { get; set; }

    [Required]
    public string ClientSignature { get; set; }

    [Required]
    public DateTime ClientSignatureDate { get; set; }

    [Required]
    public string GuarantorSignature { get; set; }

    [Required]
    public DateTime GuarantorSignatureDate { get; set; }

    [Required]
    public string CompanySignature { get; set; }

    [Required]
    public DateTime CompanySignatureDate { get; set; }

    [Required]
    public string AcknowledgmentClientSignature { get; set; }

    [Required]
    public DateTime AcknowledgmentClientSignatureDate { get; set; }
}