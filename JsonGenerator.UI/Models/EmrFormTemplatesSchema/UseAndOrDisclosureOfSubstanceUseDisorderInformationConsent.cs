using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(UseAndOrDisclosureOfSubstanceUseDisorderInformationConsent))]
[Description(nameof(UseAndOrDisclosureOfSubstanceUseDisorderInformationConsent))]
public class UseAndOrDisclosureOfSubstanceUseDisorderInformationConsent
{
    [Required]
    public string ClientName { get; set; }

    [Required]
    public string LegalNameOfProvider { get; set; }

    [Required]
    public HealthInformationDisclosure HealthInformationDisclosure { get; set; }

    [Required]
    public PersonOrEntity PersonOrEntity { get; set; }

    [Required]
    public PurposeOfTheUseAndOrDisclosure PurposeOfTheUseAndOrDisclosure { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string ClientOrParentGuardianConservatorSignatureUrl { get; set; }

    [Required]
    public DateTime ClientOrParentGuardianConservatorSignatureDate { get; set; }

    public string ClientOrParentGuardianConservatorDescription { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class PurposeOfTheUseAndOrDisclosure
{
    [Required]
    public bool ClientsRequest { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string PurposeOfTheUseAndOrDisclosureOther { get; set; }
}

public class PersonOrEntity
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string StreetAddress { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public string Zip { get; set; }

    [Required]
    public int Telephone { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class HealthInformationDisclosure
{
    [Required]
    public bool EntireMedicalClinicalRecord { get; set; }

    [Required]
    public bool ClientInASubstanceUseDisorderTreatmentProgram { get; set; }

    [Required]
    public bool ProgressWithSubstanceUseDisorderTreatment { get; set; }

    [Required]
    public bool Diagnosis { get; set; }

    [Required]
    public bool MedicalHistory { get; set; }

    [Required]
    public bool PhysicalExamResults { get; set; }

    [Required]
    public bool MedicationHistoryAnCurrentMedications { get; set; }

    [Required]
    public bool PsychologicalAssessmentsIncludingBiopsychosocialAssessment { get; set; }

    [Required]
    public bool PsychiatricHistoryAndAssessments { get; set; }

    [Required]
    public bool TreatmentAndRecoveryPlans { get; set; }

    [Required]
    public bool LaboratoryTestResults { get; set; }

    [Required]
    public bool AftercareRecommendations { get; set; }

    [Required]
    public bool DischargePlanning { get; set; }

    [Required]
    public bool DischargeSummary { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string OtherHealthInformationDisclosure { get; set; }
}