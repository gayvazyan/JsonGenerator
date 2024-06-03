using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(InitialPhysicianEvaluationWithPhysicalExam))]
[Description(nameof(InitialPhysicianEvaluationWithPhysicalExam))]
[IfMin(nameof(Medications), 1, nameof(Medications))]
[If(nameof(IsClientCurrentlyEmployed), true, nameof(IsClientCurrentlyEmployed))]
[If(nameof(General), false, nameof(General))]
[If(nameof(Chest), false, nameof(Chest))]
[If(nameof(Cardiovascular), false, nameof(Cardiovascular))]
[If(nameof(Abdomen), false, nameof(Abdomen))]
[If(nameof(Neuromuscular), false, nameof(Neuromuscular))]
[If(nameof(MentalStatus), false, nameof(MentalStatus))]
[If(nameof(Skin), false, nameof(Skin))]
[If(nameof(Plan), nameof(EmrFormTemplatesSchema.PlanType.Additional), nameof(Plan))]
[IfEnum(nameof(PlanType))]
public class InitialPhysicianEvaluationWithPhysicalExam
{
    [Required]
    public DateTime EvaluationDate { get; set; }

    [Required]
    public Gender Gender { get; set; }

    [Required]
    [Minimum(0)]
    [Maximum(200)]
    public int Age { get; set; }

    [Required]
    public MartialStatus MartialStatus { get; set; }

    [Required]
    public string ChiefComplaint { get; set; }

    public List<PhysicianEvaluationAllergy> Allergies { get; set; }
    public List<PhysicianEvaluationMedication> Medications { get; set; }

    [Required(ConditionGroup = nameof(Medications))]
    public List<QuestionAboutMedication> QuestionsAboutMedications { get; set; }

    [Required]
    [MinItems(1)]
    public List<PhysicianEvaluationSubstanceHistory> SubstanceHistory { get; set; }

    public List<PhysicianEvaluationOtherDrugUse> OtherDrugUses { get; set; }

    [Required]
    [MinItems(1)]
    public PhysicianEvaluationTopThreeDrugsOfChoice TopThreeDrugsOfChoice { get; set; }

    [Required]
    [MinItems(1)]
    public List<PhysicianEvaluationRecentSubstanceUse> MostRecentSubstanceUses { get; set; }

    [Required]
    [MinItems(1)]
    public List<PhysicianEvaluationSubstanceUseOverPastSevenDays> OverPastSevenDaysSubstanceUses { get; set; }

    [Required]
    [MinItems(1)]
    public List<PhysicianEvaluationSubstanceUseOverPastYear> OverPastYearSubstanceUses { get; set; }

    [Required]
    [MinItems(1)]
    public List<PhysicianEvaluationWithdrawalSymptom> WithdrawalSymptoms { get; set; }

    public string FamilyHistoryOfSubstanceAbuseOrMentalHealth { get; set; }

    [Required]
    public string PatientResidesWith { get; set; }

    public bool IsClientCurrentlyEmployed { get; set; }

    [Required(ConditionGroup = nameof(IsClientCurrentlyEmployed))]
    public string Occupation { get; set; }

    public List<PastTreatmentHistory> PastTreatmentHistory { get; set; }

    [Required]
    public string LongestPeriodOfSobrietyAfterAnyPreviousAttemptToQuit { get; set; }

    public string PastMedicalHistory { get; set; }
    public string PastSurgicalHistory { get; set; }

    [Required]
    public TobaccoAndNicotineUse TobaccoAndNicotineUse { get; set; }

    [Required]
    public DateTime PhysicalExamDateTime { get; set; }

    [Required]
    [Maximum(400)]
    public int BpSystolic { get; set; }

    [Required]
    [Minimum(30)]
    public int BpDiastolic { get; set; }

    [Required]
    [Minimum(0)]
    [Maximum(150)]
    public int Temperature { get; set; }

    [Required]
    [Minimum(20)]
    [Maximum(150)]
    public int Pulse { get; set; }

    [Required]
    [Maximum(80)]
    public int Respiration { get; set; }

    [Required]
    [Minimum(70)]
    [Maximum(100)]
    public int O2Saturation { get; set; }

    public string AdditionalComments { get; set; }

    [Required]
    public DateTime HeightWeightDateTime { get; set; }

    [Required]
    public int HeightMeters { get; set; }

    [Required]
    public int HeightCentimeters { get; set; }

    [Required]
    public int Weight { get; set; }

    [Required]
    public int TargetBodyWeight { get; set; }

    [Required]
    public bool General { get; set; }

    [Required(ConditionGroup = nameof(General))]
    public string GeneralComment { get; set; }

    [Required]
    public bool Chest { get; set; }

    [Required(ConditionGroup = nameof(Chest))]
    public string ChestComment { get; set; }

    [Required]
    public bool Cardiovascular { get; set; }

    [Required(ConditionGroup = nameof(Cardiovascular))]
    public string CardiovascularComment { get; set; }

    [Required]
    public bool Abdomen { get; set; }

    [Required(ConditionGroup = nameof(Abdomen))]
    public string AbdomenComment { get; set; }

    [Required]
    public bool Neuromuscular { get; set; }

    [Required(ConditionGroup = nameof(Neuromuscular))]
    public string NeuromuscularComment { get; set; }

    [Required]
    public bool MentalStatus { get; set; }

    [Required(ConditionGroup = nameof(MentalStatus))]
    public string MentalStatusComment { get; set; }

    [Required]
    public bool Skin { get; set; }

    [Required(ConditionGroup = nameof(Skin))]
    public string SkinComment { get; set; }

    [Required]
    public List<string> PatientDiagnosis { get; set; }

    [Required]
    [MinItems(1)]
    public List<PlanType> Plan { get; set; }

    public List<MedicationCustomization> MedicationCustomizations { get; set; }

    [Required(ConditionGroup = nameof(Plan))]
    [MinItems(1)]
    public List<string> PlanAdditional { get; set; }

    public string AdditionalComment { get; set; }

    [Required]
    [MinItems(1)]
    public List<PhysicianEvaluationTreatmentRecommendation> TreatmentRecommendation { get; set; }

    public bool RisksBenefitsSideEffectsAndDosageExplained { get; set; }
    public bool ClientVerbalizedUnderstandingAndHadOpportunityToAskQuestions { get; set; }
}

public class MedicationCustomization
{
    [Required(ConditionGroup = PlanType.OpiateDetoxProtocolOne)]
    public List<OpiateDetoxProtocolOneOption> OpiateDetoxProtocolOneCustomizations { get; set; }

    [Required(ConditionGroup = PlanType.OpiateDetoxProtocolTwo)]
    public List<OpiateDetoxProtocolTwoOption> OpiateDetoxProtocolTwoCustomizations { get; set; }

    [Required(ConditionGroup = PlanType.OpiateDetoxProtocolThree)]
    public List<OpiateDetoxProtocolThreeOption> OpiateDetoxProtocolThreeCustomizations { get; set; }

    [Required(ConditionGroup = PlanType.AlcoholSedativeDetoxProtocolFour)]
    public List<AlcoholSedativeDetoxProtocolFourOption> AlcoholSedativeDetoxProtocolFourCustomizations { get; set; }

    [Required(ConditionGroup = PlanType.Additional)]
    public List<string> OtherCustomizations { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum OpiateDetoxProtocolOneOption
{
    Vistaril,
    Zofran,
    Trazodone,
    Methocarbamol,
    Clonidine
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum OpiateDetoxProtocolTwoOption
{
    Vistaril,
    Zofran,
    Trazodone,
    Methocarbamol,
    Clonidine
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum OpiateDetoxProtocolThreeOption
{
    LorazepamFiveDays,
    LorazepamOneDay,
    Zofran,
    Trazodone,
    Methocarbamol,
    Clonidine,
    Gabapentin,
    BComplex,
    Folate,
    Mvi,
    Vistaril
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum AlcoholSedativeDetoxProtocolFourOption
{
    LorazepamOneDay,
    Zofran,
    Trazodone,
    Methocarbamol,
    Clonidine,
    Gabapentin,
    BComplex,
    Folate,
    Mvi
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PhysicianEvaluationTreatmentRecommendation
{
    WithdrawalManagementWPrescriptionRegimen,
    DetoxResidentialTreatment,
    TwentyFourHourMonitoring,
    IndividualPsychotherapy,
    GroupPsychotherapy,
    FamilyPsychotherapy,
    PsychoEducationalGroups,
    CaseManagement,
    AftercarePlan,
    PsychiatricServices
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Gender
{
    Male,
    Female
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MartialStatus
{
    Married,
    Partnered,
    Separated,
    Divorced,
    Widowed,
    Single
}

public class PhysicianEvaluationAllergy
{
    [Required]
    public string Allergen { get; set; }

    public string AllergyType { get; set; }
    public DateTime OnsetDate { get; set; }
    public bool State { get; set; }
    public string Reference { get; set; }

    [Required]
    public string Reaction { get; set; }

    [Required]
    public string Treatment { get; set; }
}

public class PhysicianEvaluationMedication
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

public class QuestionAboutMedication
{
    public bool NoEvidenceOfSideEffects { get; set; }
    public bool NoEvidenceOfTardiveDyskinesia { get; set; }
    public bool HasBasicKnowledgeAboutEffectsAndSideEffects { get; set; }
}

public class PhysicianEvaluationSubstanceHistory
{
    [Required]
    public PhysicianEvaluationDrugType Type { get; set; }

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

public class PhysicianEvaluationOtherDrugUse
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

public class PhysicianEvaluationTopThreeDrugsOfChoice
{
    public string DrugOfChoiceOne { get; set; }
    public string DrugOfChoiceTwo { get; set; }
    public string DrugOfChoiceThree { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PhysicianEvaluationDrugType
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

public class PhysicianEvaluationRecentSubstanceUse
{
    [Required]
    public string TypeOfDrug { get; set; }

    [Required]
    public string Frequency { get; set; }

    [Required]
    public string Quantity { get; set; }

    [Required]
    public string Method { get; set; }
}

public class PhysicianEvaluationSubstanceUseOverPastSevenDays
{
    [Required]
    public string TypeOfDrug { get; set; }

    [Required]
    public string Frequency { get; set; }

    [Required]
    public string Quantity { get; set; }

    [Required]
    public string Method { get; set; }
}

public class PhysicianEvaluationSubstanceUseOverPastYear
{
    [Required]
    public string TypeOfDrug { get; set; }

    [Required]
    public string Frequency { get; set; }

    [Required]
    public string Quantity { get; set; }

    [Required]
    public string Method { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PhysicianEvaluationWithdrawalSymptom
{
    Sweating,
    PulseOverHundredBpm,
    Tremors,
    Insomnia,
    Nausea,
    Vomiting,
    Hallucinations,
    Illusions,
    Restlessness,
    Anxiety,
    MuscleSpasms,
    Seizures,
    DepressedMood,
    JointMuscleAches,
    CryingSpells,
    RunnyNose,
    PupillaryDilation,
    Chills,
    Diarrhea,
    Yawning,
    Fever,
    ClientDeniesHavingWithdrawalSymptoms,
    GeneralizedAnxiety,
    AbdominalCramps,
    Dizziness,
    Agitation,
    Hypersensitivity,
    Headaches,
    DifficultyBreathing,
    Nervousness,
    SleepDisturbance,
    AppetiteDisturbance,
    LowEnergy,
    Irritability,
    PressuredSpeech,
    WeightLossGain,
    PanicAttacks,
    SexualDysfunction,
    ParanoidIdeation,
    DifficultyConcentrating,
    UnableToFocus,
    ImpulseControlProblems,
    ConductProblems,
    AcuteStressDisorder
}

public class PastTreatmentHistory
{
    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Provider { get; set; }

    [Required]
    public string Treatment { get; set; }

    [Required]
    public string DurationOrFrequency { get; set; }

    [Required]
    public Outcome Outcome { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Outcome
{
    SuccessfulCompletion,
    AmaApa,
    DischargedNonCompliant,
    Other
}

[If(nameof(Nonsmoker), false, nameof(Nonsmoker))]
public class TobaccoAndNicotineUse
{
    [Required]
    public bool Nonsmoker { get; set; }

    [Required(ConditionGroup = nameof(Nonsmoker))]
    public string Smoker { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PlanType
{
    OpiateDetoxProtocolOne,
    OpiateDetoxProtocolTwo,
    OpiateDetoxProtocolThree,
    AlcoholSedativeDetoxProtocolFour,
    Additional
}