using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(SlidingScaleFeeAssistanceProgramApplication))]
[Description(nameof(SlidingScaleFeeAssistanceProgramApplication))]
public class SlidingScaleFeeAssistanceProgramApplication
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string PlaceOfEmployment { get; set; }

    [Required]
    public string NameOfHeadOfHousehold { get; set; }

    [Required]
    public string Street { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    [Minimum(0)]
    public int Zip { get; set; }

    [Required]
    [Minimum(0)]
    public int Phone { get; set; }

    [Required]
    public SpouseOrDependents SpouseAndDependents { get; set; }

    [Required]
    public AnnualHouseholdIncome AnnualHouseholdIncome { get; set; }


    [Required]
    public string NamePrinted { get; set; }

    [Required]
    public string Signature { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string ClientName { get; set; }

    [Required]
    [Minimum(0)]
    public decimal ApprovedPercentageReduction { get; set; }

    [Required]
    public string ApprovedBy { get; set; }

    [Required]
    public DateTime DateApproved { get; set; }

    [Required]
    public VerificationChecklist VerificationChecklist { get; set; }
}

public class SpouseOrDependents
{
    [Required]
    public SpouseAndDependent Self { get; set; }

    public SpouseAndDependent Spouse { get; set; }
    public List<SpouseAndDependent> Dependents { get; set; }
}