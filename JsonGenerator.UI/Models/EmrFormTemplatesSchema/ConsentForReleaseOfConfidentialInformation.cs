using System;
using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(ClinicalInstituteWithdrawalAssessment))]
[Description(nameof(ClinicalInstituteWithdrawalAssessment))]
public class ConsentForReleaseOfConfidentialInformation
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string ClientName { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public AuthorizedPermission AuthorizedPermissions { get; set; }

    [Required]
    public string NameOfPersonAgency { get; set; }

    [Required]
    public string Address { get; set; }

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
    [Minimum(0)]
    public int CellNumber { get; set; }

    [Required]
    public string FaxNumber { get; set; }

    [Required]
    public string EmailAddress { get; set; }

    [Required]
    public RelationshipToPatient RelationshipToPatient { get; set; }

    [Required]
    public InformationType FollowingInformation { get; set; }


    [Required]
    public ReasonForReleaseOfInformation ReasonsForReleaseOfInformation { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class ReasonForReleaseOfInformation
{
    [Required]
    public bool ContinuityOfTreatmentPatientHistoryCaseManagementServices { get; set; }

    [Required]
    public bool EmergencyContactGeneralUpdates { get; set; }

    [Required]
    public bool CourtServicesLegalPurposesProbationDisabilityClaimingUnemploymentClaimingEmploymentContinuity
    {
        get;
        set;
    }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string ReasonForReleaseOfInformationOther { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum RelationshipToPatient
{
    TreatmentCenter,
    SpouseSignificantOther,
    Parent,
    DaughterSon,
    CaseManager,
    Court,
    ProbationOfficer,
    Sponsor,
    Friend,
    Other
}

[If(nameof(Other), true, nameof(Other))]
public class InformationType
{
    [Required]
    public bool PresenceInTreatment { get; set; }

    [Required]
    public bool MedicalHistoryCurrentStatus { get; set; }

    [Required]
    public bool AftercareRecommendations { get; set; }

    [Required]
    public bool ProgressInTreatment { get; set; }

    [Required]
    public bool BiopsychosocialAssessment { get; set; }

    [Required]
    public bool DischargePlanning { get; set; }

    [Required]
    public bool TreatmentPlans { get; set; }

    [Required]
    public bool LaboratoryTestResults { get; set; }

    [Required]
    public bool DischargeSummary { get; set; }

    [Required]
    public bool PsychologicalAssessment { get; set; }

    [Required]
    public bool EmploymentInformation { get; set; }

    [Required]
    public bool PsychiatricHistoryAndAssessment { get; set; }

    [Required]
    public bool LegalStatus { get; set; }

    [Required]
    public bool ResultsOfPhysicalExam { get; set; }

    [Required]
    public bool FamilyInformation { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string FollowingInformationOther { get; set; }
}

public class AuthorizedPermission
{
    [Required]
    public bool DiscloseTo { get; set; }

    [Required]
    public bool ObtainFrom { get; set; }

    [Required]
    public bool Electronic { get; set; }

    [Required]
    public bool Oral { get; set; }

    [Required]
    public bool Written { get; set; }
}