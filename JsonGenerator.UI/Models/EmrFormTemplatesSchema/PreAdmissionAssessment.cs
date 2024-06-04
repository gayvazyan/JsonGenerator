using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class PreAdmissionAssessment
{
    [Required]
    public Guid FormRef { get; set; }

    [Required]
    public DateTime EvaluationDate { get; set; }

    [Required]
    public string PresentingFactorsForTreatmentSummary { get; set; }

    public bool? PreviousTreatment { get; set; }

    [Required]
    public string RelapseHistory { get; set; }

    public string PastMedicalHistory { get; set; }

    public string PastSurgicalHistory { get; set; }

    [Required]
    public string CurrentPhysician { get; set; }

    public string MedicationsBrought { get; set; }

    public string PurposeOfMedicationsBrought { get; set; }

    public string MentalHealthDiagnosis { get; set; }

    public string SocialServices { get; set; }

    public string CriminalJustice { get; set; }

    [Required]
    public int ClientEnterAge { get; set; }

    [Required]
    public bool ClientIncarcerated { get; set; }

    public string FamilyHistory { get; set; }

    [Required]
    public bool IsClientCurrentlyEmployed { get; set; }

    public string Occupation { get; set; }

    [Required]
    public PreAdmissionAssessmentSchemaYesOrNo InJeopardy { get; set; }

    [Required]
    public string ClientResidesWith { get; set; }

    [Required]
    public PreAdmissionAssessmentSchemaYesOrNo AreTheySober { get; set; }

    [Required]
    public bool HasChildren { get; set; }

    public int NumberOfChildren { get; set; }

    public int ChildrenAreFromNumberOfPartners { get; set; }

    public string FamilyProblems { get; set; }

    [Required]
    public bool RecommendationToAdmit { get; set; }

    public bool? ClientWasReferredTo { get; set; }

    public string ClientWasReferredToWhere { get; set; }
    public List<SubstanceHistory> SubstanceHistories { get; set; }
    public List<OtherDrugUse> OtherDrugUses { get; set; }
    public List<PastYearDrugUse> PastYearDrugUses { get; set; }
    public List<PastSevenDaysDrugUse> DrugUseInPastSevenDays { get; set; }
    public List<RecentSubstanceUse> RecentSubstanceUses { get; set; }
    public List<PreviousTreatment> PreviousTreatments { get; set; }
    public List<IncarcerationHistory> IncarcerationHistories { get; set; }
    public TopThreeDrugsOfChoice TopThreeDrugsOfChoice { get; set; }
    public TobaccoNicotineUse TobaccoNicotineUse { get; set; }
    public AlcoholWithdrawal AlcoholWithdrawal { get; set; }
    public OpioidWithdrawal OpioidWithdrawal { get; set; }
    public PreAdmissionAssessmentOtherOption PreAdmissionAssessmentOtherOption { get; set; }
}

public class SubstanceHistory
{
    [Required]
    public PreAdmissionAssessmentDrugType Type { get; set; }

    [Required]

    public DateTime? FirstUsed { get; set; }

    [Required]
    public DateTime? LastUsed { get; set; }

    [Required]
    public string Frequency { get; set; }

    [Required]
    public int? Amount { get; set; }

    [Required]
    public string Method { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PreAdmissionAssessmentDrugType
{
    Alcohol = 0,
    Amphetamines = 1,
    Cocaine = 2,
    Crack = 3,
    Heroin = 4,
    OxysRoxys = 5,
    Percocets = 6,
    Xanax = 7,
    Klonopin = 8,
    Marijuana = 9
}

public class OtherDrugUse
{
    [Required]
    public string Type { get; set; }

    [Required]

    public DateTime? FirstUsed { get; set; }

    [Required]
    public DateTime? LastUsed { get; set; }

    [Required]
    public string Frequency { get; set; }

    [Required]
    public int? Amount { get; set; }

    [Required]
    public string Method { get; set; }
}

public class PastYearDrugUse
{
    [Required]
    public string Type { get; set; }

    [Required]

    public string Frequency { get; set; }

    [Required]
    public int? Quantity { get; set; }

    [Required]
    public string Method { get; set; }
}

public class PastSevenDaysDrugUse
{
    [Required]
    public string Type { get; set; }

    [Required]

    public string Frequency { get; set; }

    [Required]
    public int? Quantity { get; set; }

    [Required]
    public string Method { get; set; }
}

public class RecentSubstanceUse
{
    [Required]
    public DateTime DateAndTime { get; set; }

    public string Type { get; set; }
    public int? Quantity { get; set; }
    public string Method { get; set; }
}

public class TopThreeDrugsOfChoice
{
    public string DrugOfChoiceOne { get; set; }
    public string DrugOfChoiceTwo { get; set; }
    public string DrugOfChoiceThree { get; set; }
}

public class TobaccoNicotineUse
{
    [Required]
    public bool Nonsmoker { get; set; }

    public string Smoker { get; set; }
}

public class AlcoholWithdrawal
{
    public bool? Sweating { get; set; }
    public bool? Vomiting { get; set; }
    public bool? MuscleSpasms { get; set; }
    public bool? PulseOverHundredBpm { get; set; }
    public bool? Hallucinations { get; set; }
    public bool? Seizures { get; set; }
    public bool? Tremors { get; set; }
    public bool? Illusions { get; set; }
    public bool? Insomnia { get; set; }
    public bool? Restlessness { get; set; }
    public bool? Nausea { get; set; }
    public bool? Anxiety { get; set; }
}

public class OpioidWithdrawal
{
    public bool? DepressedMood { get; set; }
    public bool? RunnyNose { get; set; }
    public bool? Yawning { get; set; }
    public bool? Nausea { get; set; }
    public bool? PupilaryDilation { get; set; }
    public bool? Fever { get; set; }
    public bool? Vomiting { get; set; }
    public bool? Chills { get; set; }
    public bool? Insomnia { get; set; }
    public bool? JointMuscleAches { get; set; }
    public bool? Sweating { get; set; }
    public bool? CryingSpells { get; set; }
    public bool? Diarrhea { get; set; }
}

public class PreAdmissionAssessmentOtherOption
{
    public bool? ClientDeniesExperiencingWithdrawalSymptoms { get; set; }
    public bool? SleepDisturbance { get; set; }
    public bool? PressuredSpeech { get; set; }
    public bool? DifficultyConcentrating { get; set; }
    public bool? GeneralizedAnxiety { get; set; }
    public bool? Hypersensitivity { get; set; }
    public bool? AppetiteDisturbance { get; set; }
    public bool? WeightLossGain { get; set; }
    public bool? UnableToFocus { get; set; }
    public bool? AbdominalCramps { get; set; }
    public bool? Headachs { get; set; }
    public bool? LowEnergy { get; set; }
    public bool? PanicAttacks { get; set; }
    public bool? ImpulseControlProblems { get; set; }
    public bool? Dizziness { get; set; }
    public bool? DifficultyBreathing { get; set; }
    public bool? Agitation { get; set; }
    public bool? SexualDysfunction { get; set; }
    public bool? ConductProblems { get; set; }
    public bool? Nervousness { get; set; }
    public bool? Irritability { get; set; }
    public bool? ParanoidIdeation { get; set; }
    public bool? AcuteStressDisorder { get; set; }
}

public class IncarcerationHistory
{
    [Required]
    public DateTime Date { get; set; }

    public string Charges { get; set; }

    public int DurationOrLocation { get; set; }

    public string Disposition { get; set; }
}

public class PreviousTreatment
{
    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Treatment { get; set; }

    [Required]
    public string Provider { get; set; }

    [Required]
    public string DurationOrFrequency { get; set; }

    [Required]
    public PreviousTreatmentOutcome Outcome { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PreAdmissionAssessmentSchemaYesOrNo
{
    Yes = 0,
    No = 1,
    Na = 2,
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PreviousTreatmentOutcome
{
    SuccessfulCompletion,
    AmaOrApa,
    DischargedOrNonCompliant,
    Other
}