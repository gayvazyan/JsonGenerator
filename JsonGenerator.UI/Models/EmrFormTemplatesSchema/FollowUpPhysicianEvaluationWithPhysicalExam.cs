using System;
using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(FollowUpPhysicianEvaluationWithPhysicalExam))]
[Description(nameof(FollowUpPhysicianEvaluationWithPhysicalExam))]
[If(nameof(PrescribedMedications), nameof(PlanType.Additional), nameof(PrescribedMedications))]

[If(nameof(InterimTreatmentUpdates), nameof(InterimTreatmentUpdate.Other), nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates), nameof(InterimTreatmentUpdate.OtherCravings), nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates), nameof(InterimTreatmentUpdate.PatientReportsContinuedDifficultyWith),
    nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates),
    nameof(InterimTreatmentUpdate.PatientReportsContinuedMildToModerateWithdrawalSymptoms),
    nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates),
    nameof(InterimTreatmentUpdate.PatientStatesSymptomsAreImprovingButMildWithdrawalSymptomsStillPresent),
    nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates), nameof(InterimTreatmentUpdate.OtherSleep), nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates), nameof(InterimTreatmentUpdate.OtherAppetite), nameof(InterimTreatmentUpdates))]
[If(nameof(InterimTreatmentUpdates), nameof(InterimTreatmentUpdate.OtherSideEffect), nameof(InterimTreatmentUpdates))]
[If(nameof(Plans), nameof(FollowUpPhysicianEvaluationPlan.StartTheFollowingMedications), nameof(Plans))]
[If(nameof(Plans), nameof(FollowUpPhysicianEvaluationPlan.RefillTheFollowingMedications), nameof(Plans))]
[If(nameof(Plans), nameof(FollowUpPhysicianEvaluationPlan.IncreaseTheDoseOfTheFollowingMedicationsAsFollows),
    nameof(Plans))]
[If(nameof(Plans), nameof(FollowUpPhysicianEvaluationPlan.DecreaseTheDoseOfTheFollowingMedicationsAsFollows),
    nameof(Plans))]
[If(nameof(Plans), nameof(FollowUpPhysicianEvaluationPlan.DiscontinueTheFollowingMedications), nameof(Plans))]
[If(nameof(ChiefComplaint), false, nameof(ChiefComplaint))]
[If(nameof(General), false, nameof(General))]
[If(nameof(Chest), false, nameof(Chest))]
[If(nameof(Cardiovascular), false, nameof(Cardiovascular))]
[If(nameof(Abdomen), false, nameof(Abdomen))]
[If(nameof(Neuromuscular), false, nameof(Neuromuscular))]
[If(nameof(MentalStatus), false, nameof(MentalStatus))]
[If(nameof(Skin), false, nameof(Skin))]
public class FollowUpPhysicianEvaluationWithPhysicalExam
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

    public DateTime DateAdmittedToCarusRecovery { get; set; }

    public bool ChiefComplaint { get; set; }

    [Required(ConditionGroup = nameof(ChiefComplaint))]
    public string ChiefComplaintComment { get; set; }

    [Required]
    [MinItems(1)]
    public System.Collections.Generic.List<InterimHistory> InterimHistories { get; set; }


    [Required]
    [MinItems(1)]
    public System.Collections.Generic.List<PlanType> PrescribedMedications { get; set; }

    public System.Collections.Generic.List<MedicationCustomization> MedicationCustomizations { get; set; }

    [Required(ConditionGroup = nameof(PrescribedMedications))]
    [MinItems(1)]
    public System.Collections.Generic.List<string> PrescribedMedicationAdditional { get; set; }

    public string PrescribedMedicationAdditionalComment { get; set; }

    [Required]
    [MinItems(1)]
    public System.Collections.Generic.List<InterimTreatmentUpdate> InterimTreatmentUpdates { get; set; }

    [Required(ConditionGroup = nameof(InterimTreatmentUpdates))]
    public System.Collections.Generic.List<string> InterimTreatmentAdditionalComment { get; set; }

    public System.Collections.Generic.List<PhysicianEvaluationAllergy> Allergies { get; set; }

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

    public string AdditionalCommentsPhysicalExam { get; set; }

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
    public System.Collections.Generic.List<FollowUpPhysicianEvaluationPlan> Plans { get; set; }

    [Required(ConditionGroup = nameof(Plans))]
    public System.Collections.Generic.List<string> AdditionalCommentPlan { get; set; }

    public string AdditionalComment { get; set; }
}

public enum FollowUpPhysicianEvaluationPlan
{
    ClientWillContinueToTakeAllPrescribedMedicationsAsDescribedAbove,
    ContinueCurrentDetoxProtocolMedicationRegimen,
    StartTheFollowingMedications,
    RefillTheFollowingMedications,
    IncreaseTheDoseOfTheFollowingMedicationsAsFollows,
    DecreaseTheDoseOfTheFollowingMedicationsAsFollows,
    DiscontinueTheFollowingMedications
}

public enum GeneralObservation
{
    PatientAtThisTimeAppearsUncomfortableDiaphoreticDisheveled,
    PatientAtThisTimeAppearsProperlyGroomedToBeInNoApparentAcutePhysicalDistressAbleToEasilyAmbulateWithoutAssistance
}

public enum InterimHistory
{
    SweatingPulseOverHundredBpm,
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
    PupilaryDilation,
    Chills,
    Diarrhea,
    Yawning,
    Fever,
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
    AgitationIrritability,
    PressuredSpeech,
    WeightLossGain,
    PanicAttacks,
    SexualDysfunction,
    ParanoidIdeation,
    DifficultyConcentrating,
    UnableToFocus,
    ImpulseControlProblems,
    ConductProblems,
    AcuteStressDisorder,
    ClientDeniesHavingWithdrawalSymptoms
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum InterimTreatmentUpdate
{
    PatientIsSeenTodayForAFollowUpExamAndReviewOfHisCurrentSymptoms,
    PatientHasBeenFullyActiveAndParticipatingInHisCurrentTreatmentProgram,
    PatientHasBeenToleratingHisDetoxProtocol,
    Other,
    PatientReportsExperiencingNoCravingsAtThisTime,
    PatientReportsExperiencingIntermittentCravings,
    OtherCravings,
    PatientReportsContinuedDifficultyWith,
    PatientReportsContinuedMildToModerateWithdrawalSymptoms,
    PatientStatesSymptomsAreImprovingButMildWithdrawalSymptomsStillPresent,
    PatientDescribesHisSleepAsRestlessGettingOnAverage26HoursOfSleepPerNight,
    PatientDescribesHisSleepAsGoodGettingOnAverage68HoursOfSleepPerNight,
    OtherSleep,
    PatientDescribesHisAppetiteAsGoodAndBelievesHisWeightHasBeenAboutTheSameSinceAdmission,
    PatientDescribesHisAppetiteAsGoodAndBelievesHisWeightHasBeenIncreasingSinceAdmission,
    PatientReportsAppetiteDisturbanceAndOrDifficultyEatingBelievesPossibleWeightLossSinceAdmission,
    OtherAppetite,
    PatientDeniesAnyCurrentSideEffectsFromHisCurrentMedications,
    PatientReportsPossibleSideEffectsFromMedications,
    OtherSideEffect
}

public enum AllergyType
{
    Drug,
    Food,
    Insect,
    Other
}

public enum State
{
    Active,
    Inactive
}

public enum General
{
    UncomfortableDiaphoreticDisheveled,
    ProperlyGroomed,
    NoApparentPhysicalDistress
}

public class FollowUpPhysicianEvaluation
{
    public string Description { get; set; }
    public bool Start { get; set; }
    public bool Refill { get; set; }
    public bool IncreaseDose { get; set; }
    public bool DecreaseDose { get; set; }
    public bool Discontinue { get; set; }
    public string AdditionalComment { get; set; }
}