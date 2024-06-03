using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(DischargeSummary))]
[Description(nameof(DischargeSummary))]
public class DischargeSummary
{
    [Required]
    public DateTime Date { get; set; }

    [Required]
    public DateTime DateOfAdmission { get; set; }

    [Required]
    public DateTime DateOfDischarge { get; set; }

    [Required]
    public string AdmissionDiagnosis { get; set; }

    [Required]
    public string DischargeDiagnosis { get; set; }

    [Required]
    public ReasonForDischarge ReasonForDischarge { get; set; }

    [Required]
    public string LengthOfStay { get; set; }

    [Required]
    [MinItems(1)]
    [UniqueItems(true)]
    public List<ProvidedService> SummaryOfProvidedServices { get; set; }

    public string ProvidedServiceComment { get; set; }

    [Required]
    public string MedicalIssuesAtTheTimeOfDischargeForFollowUp { get; set; }

    [Required]
    public List<MedicationAtTimeOfDischarge> MedicationsAtTimeOfDischarge { get; set; }

    [Required]
    public string ClinicalSummaryOfClientsResponseToTreatment { get; set; }

    [Required]
    public string ConditionAtDischarge { get; set; }

    [Required]
    public string UnresolvedIssuesThatCouldAffectContinuingRecovery { get; set; }

    [Required]
    public DischargeSummaryGrade ComplianceToTreatment { get; set; }

    [Required]
    public DischargeSummaryGrade Prognosis { get; set; }

    [Required]
    public DischargeSummaryGrade Motivation { get; set; }

    [Required]
    public MedicationComplianceGrade MedicationCompliance { get; set; }

    [Required]
    public DischargeSummaryGrade AaNaAttendance { get; set; }

    [Required]
    [MinItems(1)]
    [UniqueItems(true)]
    public List<NeededOtherService> ProvisionOfNeededOtherServices { get; set; }

    public string ProvisionOfNeededOtherServiceComment { get; set; }
}

public class MedicationAtTimeOfDischarge
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string DozeStrength { get; set; }

    [Required]
    public MedicationInventoryType InventoryType { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public MedicationScheduleType ScheduleType { get; set; }

    [Required]
    public int TotalInitialQuantity { get; set; }

    [Required]
    public int TakenQuantity { get; set; }

    [Required]
    public int TotalLeftQuantity { get; set; }

    [Required]
    public MedicationAtTimeOfDischargeStatus Status { get; set; }

    [Required]
    public string Reason { get; set; }

    public string Notes { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MedicationInventoryType
{
    DoctorsOrder = 1,
    BroughtIn = 2,
    MedicationFacility = 4
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MedicationScheduleType
{
    Regular,
    Taper,
    Once
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MedicationAtTimeOfDischargeStatus
{
    Pending = 1,
    InProgress = 2,
    Taken = 4,
    Canceled = 8
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum NeededOtherService
{
    HalfwayHouse,
    Op,
    Iop,
    DualDiagnosis,
    LongTermResidential,
    ReturnToIndependentResidence,
    AaNaMeetingAttendance,
    JobTraining,
    Housing,
    GedEducation,
    LegalServices,
    TraumaReferral,
    MedicalAppointment,
    Other
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum DischargeSummaryGrade
{
    Poor,
    FairGuarded,
    Good,
    Excellent
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MedicationComplianceGrade
{
    NotApplicable,
    Poor,
    FairGuarded,
    Good,
    Excellent
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum ProvidedService
{
    PsychiatricAssessment,
    RecreationalTherapy,
    GroupTherapy,
    HivEducation,
    IndividualCounseling,
    TwelveStepMeetings,
    MedicationReviewsMonitoring,
    PsychoSocialAssessment,
    FamilyMeetings,
    LifeSkills,
    PsychoEducationalGroup,
    Other
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum ReasonForDischarge
{
    AdministrativeDischargeInitiatedByTheAgency,
    AgencyClosedWithNoReferral,
    CompletedEpisodeOfCareSubstanceFreeForAtLeast30Days,
    CompletedTreatment,
    Deceased,
    Incarcerated,
    LeftInvoluntarilyBeforeCompletingTreatment,
    LeftVoluntarilyBeforeCompletingTreatmentAgainstMedicalClinicalOrStaffAdvice,
    NonCompliantWithRulesOfAgency,
    ReferredOutsideOfAgencyEpisodeOfCareCompleted,
    ReferredOutsideOfAgencyEpisodeOfCareNotCompleted,
}