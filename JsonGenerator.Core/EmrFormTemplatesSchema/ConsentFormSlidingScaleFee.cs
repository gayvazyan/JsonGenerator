using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(ConsentFormSlidingScaleFee))]
[Description(nameof(ConsentFormSlidingScaleFee))]
public class ConsentFormSlidingScaleFee
{
    [Required]
    public string Comapany { get; set; }

    [Required]
    public string HeadOfHousehold { get; set; }

    [Required]
    public string PlaceOfEmployment { get; set; }

    [Required]
    [Minimum(0)]
    public int Phone { get; set; }

    [Required]
    public string Street { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    [Minimum(0)]
    public int Zip { get; set; }

    public List<SpouseAndDependent> SpouseAndDependents { get; set; }

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

public class VerificationChecklist
{
    [Required]
    public bool IdentificationAndAddress { get; set; }

    [Required]
    public bool Income { get; set; }

    [Required]
    public bool Insurance { get; set; }
}

public class AnnualHouseholdIncome
{
    [Required]
    public IncomeSource GrossWagesSalariesTips { get; set; }

    [Required]
    public IncomeSource IncomeFromBusinessSelfEmploymentAndDependents { get; set; }

    [Required]
    public IncomeSource SocialCompensation { get; set; }

    [Required]
    public IncomeSource OtherMiscellaneousSources { get; set; }

    [Required]
    public IncomeSource TotalIncome { get; set; }
}

public class IncomeSource
{
    public int Self { get; set; }
    public int Spouse { get; set; }
    public int Other { get; set; }

    [Required]
    public int Total { get; set; }
}

public class SpouseAndDependent
{
    [Required]
    public string Name { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }
}