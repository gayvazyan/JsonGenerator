using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(InitialPsychiatricEvaluation))]
[Description(nameof(InitialPsychiatricEvaluation))]
public class InitialPsychiatricEvaluation
{
    [Required]
    public DateTime EvaluationDate { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    public DateTime EndTime { get; set; }

    [Required]
    public DateTime AdmitDateTime { get; set; }

    [Required]
    public AdmissionType AdmissionType { get; set; }

    [Required]
    public MaritalStatus MaritalStatus { get; set; }

    public List<InitialPsychiatricEvaluationAllergy> Allergies { get; set; }
    public List<Medication> Medications { get; set; }

    [Required]
    public string ChiefComplaint { get; set; }

    [Required]
    public string HistoryOfPresentIllness { get; set; }

    [Required]
    public string PastPsychiatricAndSubstanceTreatmentHistory { get; set; }

    public PertinentPastPsychiatricHistory PertinentPastPsychiatricHistories { get; set; }

    [Required]
    public string BackgroundAndSocialHistory { get; set; }

    [Required]
    public string MedicalSurgicalHistory { get; set; }

    [Required]
    public string SeizureHistory { get; set; }

    [Required]
    public string HeadTraumaHistory { get; set; }

    [Required]
    public string TraumaAbuseHistory { get; set; }

    [Required]
    public string PsychosocialDevelopmentFamilyHistoryOverview { get; set; }

    [Required]
    public string PreviousHistorySuicidalHomicidalIdeationPlan { get; set; }

    [Required]
    public string CurrentSuicidalHomicidalIdeationPlan { get; set; }

    [Required]
    public MentalStatusExamAppearance MentalStatusExamAppearance { get; set; }

    [Required]
    public MentalStatusExamSpeech MentalStatusExamSpeech { get; set; }

    [Required]
    public MentalStatusExamBehavior MentalStatusExamBehavior { get; set; }

    [Required]
    public MentalStatusExamAttitude MentalStatusExamAttitude { get; set; }

    [Required]
    public MentalStatusExamMood MentalStatusExamMood { get; set; }

    [Required]
    public MentalStatusExamAffect MentalStatusExamAffect { get; set; }

    [Required]
    public InitialPsychiatricEvaluationYesOrNo SuicidalIdeation { get; set; }

    [Required]
    public InitialPsychiatricEvaluationYesOrNo HomicidalIdeation { get; set; }

    [Required]
    public InitialPsychiatricEvaluationYesOrNo SelfDestructiveBehavior { get; set; }

    [Required]
    public ThoughtProcess ThoughtProcesses { get; set; }

    [Required]
    public ThoughtContent ThoughtContents { get; set; }

    [Required]
    public VegetativeSign VegetativeSigns { get; set; }

    [Required]
    public CognitiveAssessmentOrientation CognitiveAssessmentOrientation { get; set; }

    [Required]
    public LastFivePresident LastFivePresidents { get; set; }

    [Required]
    public ThreeObjects LearnThreeObjects { get; set; }

    public List<DigitSpan> DigitSpans { get; set; }

    [Required]
    public ThreeObjects RepeatThreeObjects { get; set; }

    [Required]
    public InitialPsychiatricEvaluationEstimate IntelligenceEstimates { get; set; }

    [Required]
    public MemoryGrade MemoryImmediateRecall { get; set; }

    [Required]
    public MemoryGrade MemoryShortTerm { get; set; }

    [Required]
    public MemoryGrade MemoryLongTerm { get; set; }

    [Required]
    public MemoryGrade MemoryConcentration { get; set; }

    [Required]
    public MemoryGrade MemoryAttention { get; set; }

    [Required]
    public InitialPsychiatricEvaluationEstimate MemoryImpulseControl { get; set; }

    [Required]
    public InitialPsychiatricEvaluationEstimate MemoryIntrospection { get; set; }

    [Required]
    public MemoryJudgementGrade MemoryJudgement { get; set; }

    [Required]
    public StrengthsAndAsset StrengthsAndAssets { get; set; }

    [Required]
    public string LiabilitiesBarriersToRecovery { get; set; }

    [Required]
    public string DiagnosticImpressionsDiagnosis { get; set; }

    public List<string> DsmFiveDiagnosisCodes { get; set; }
    public string MedicalConditions { get; set; }

    [Required]
    public PsychosocialStressor PsychosocialStressors { get; set; }

    public bool NeedForSuicidePrecautions { get; set; }
    public bool PatientFullyInformed { get; set; }

    [Required]
    public JustificationForDetox Justifications { get; set; }

    [Required]
    public TreatmentRecommendation TreatmentRecommendations { get; set; }

    public string PsychoPharmacologicInterventions { get; set; }
    public bool RisksBenefitsExplained { get; set; }
    public bool ClientVerbalizedUnderstanding { get; set; }

    [Required]
    public string FollowUp { get; set; }

    public bool TardiveDyskinesiaSigns { get; set; }
    public string PhysicianCertificationOfNeedForAdmission { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum LastFivePresident
{
    One,
    Two,
    Three,
    Four,
    Five,
}

public class TreatmentRecommendation
{
    [Required]
    public bool OpDetoxTreatment { get; set; }

    public bool PhpDayNight { get; set; }

    [Required]
    public bool MedicationManagement { get; set; }

    [Required]
    public bool HealthAndPhysicalEvaluations { get; set; }

    [Required]
    public bool EveryHourMonitoring { get; set; }

    [Required]
    public bool IndividualPsychotherapy { get; set; }

    [Required]
    public bool GroupPsychotherapy { get; set; }

    [Required]
    public bool FamilyPsychotherapy { get; set; }

    [Required]
    public bool PsychoEducationalGroups { get; set; }

    [Required]
    public bool CaseManagement { get; set; }

    [Required]
    public bool AftercarePlan { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class JustificationForDetox
{
    [Required]
    public bool PossibleDangerToSelfOrOther { get; set; }

    [Required]
    public bool AcuteHistoryOfPsychoactiveSubstanceAbuse { get; set; }

    [Required]
    public bool AcuteHistoryOfInabilityToMaintainAbsenceFromPsychoactiveSubstance { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string JustificationOther { get; set; }
}

[If(nameof(OtherPsychosocialAndEnvironmentalProblems), true, nameof(OtherPsychosocialAndEnvironmentalProblems))]
public class PsychosocialStressor
{
    [Required]
    public bool ProblemsWithPrimarySupportGroup { get; set; }

    [Required]
    public bool ProblemsWithAccessToHealthCareService { get; set; }

    [Required]
    public bool ProblemsRelatedToSocialEnvironment { get; set; }

    [Required]
    public bool ProblemsRelatedToInteractionWithLegalSystemCrime { get; set; }

    [Required]
    public bool EducationalProblems { get; set; }

    [Required]
    public bool ProblemsWithDomesticViolence { get; set; }

    [Required]
    public bool OccupationalProblems { get; set; }

    [Required]
    public bool ProblemsWithSexualAbuseTrauma { get; set; }

    [Required]
    public bool HousingProblems { get; set; }

    [Required]
    public bool ProblemsWithPhysicalAbuse { get; set; }

    [Required]
    public bool EconomicProblems { get; set; }

    [Required]
    public bool OtherPsychosocialAndEnvironmentalProblems { get; set; }

    [Required(ConditionGroup = nameof(OtherPsychosocialAndEnvironmentalProblems))]
    public string PsychosocialStressorOther { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class StrengthsAndAsset
{
    [Required]
    public bool PhysicalHealth { get; set; }

    [Required]
    public bool SupportFamily { get; set; }

    [Required]
    public bool Cooperative { get; set; }

    [Required]
    public bool CommunicationSkills { get; set; }

    [Required]
    public bool CapacityToPerformAdl { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string StrengthsAndAssetOther { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MemoryJudgementGrade
{
    Employed,
    Unemployed,
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum InitialPsychiatricEvaluationEstimate
{
    Average,
    AboveAverage,
    BelowAverage,
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MemoryGrade
{
    Intact,
    Impaired,
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum ThreeObjects
{
    ThreeOfThreeCorrect,
    TwoOfThreeCorrect,
    OneOfThreeCorrect,
    ZeroOfThreeCorrect,
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum DigitSpan
{
    NumberForward,
    NumberBackward
}

public class CognitiveAssessmentOrientation
{
    [Required]
    public bool Wnl { get; set; }

    [Required]
    public bool DisorientedToTimePlaceOrPerson { get; set; }

    [Required]
    public bool OrientedToPerson { get; set; }

    [Required]
    public bool OrientedToPlace { get; set; }

    [Required]
    public bool OrientedToTime { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class VegetativeSign
{
    [Required]
    public bool Dysphoria { get; set; }

    [Required]
    public bool Hopelessness { get; set; }

    [Required]
    public bool DecreasedAppetite { get; set; }

    [Required]
    public bool DecreasedSleep { get; set; }

    [Required]
    public bool WeightLoss { get; set; }

    [Required]
    public bool CryingSpells { get; set; }

    [Required]
    public bool Helplessness { get; set; }

    [Required]
    public bool IncreasedAppetite { get; set; }

    [Required]
    public bool IncreaseSleep { get; set; }

    [Required]
    public bool WeightGain { get; set; }

    [Required]
    public bool Anhedonia { get; set; }

    [Required]
    public bool Anergia { get; set; }

    [Required]
    public bool Preoccupation { get; set; }

    [Required]
    public bool DecreasedConcentration { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string VegetativeSignOther { get; set; }
}

public class ThoughtContent
{
    public bool Denies { get; set; }
    public CheckboxItem AuditoryHallucinations { get; set; }
    public CheckboxItem VisualHallucinations { get; set; }
    public CheckboxItem TactileHallucinations { get; set; }
    public CheckboxItem OlfactoryHallucinations { get; set; }
    public CheckboxItem VisceralHallucinations { get; set; }
    public CheckboxItem GustatoryHallucinations { get; set; }
    public CheckboxItem ParanoidThinking { get; set; }
    public CheckboxItem Obsessions { get; set; }
    public CheckboxItem Delusions { get; set; }
    public CheckboxItem DelusionsOfPersecution { get; set; }
    public CheckboxItem DelusionsOfGrandeur { get; set; }
    public CheckboxItem DelusionsOfReference { get; set; }
    public CheckboxItem DelusionsOfInfluence { get; set; }
    public CheckboxItem Somatic { get; set; }
    public CheckboxItem Paranoia { get; set; }
    public CheckboxItem DelusionsOfMindReading { get; set; }
    public CheckboxItem MagicalThinking { get; set; }
    public CheckboxItem Compulsions { get; set; }
    public CheckboxItem Preoccupation { get; set; }
    public CheckboxItem Ior { get; set; }
    public CheckboxItem PovertyOfContent { get; set; }
    public CheckboxItem Phobia { get; set; }
    public CheckboxItem FeelsPersecuted { get; set; }
    public CheckboxItem SomaticComplaints { get; set; }
    public CheckboxItem OtherComments { get; set; }
}

public class CheckboxItem
{
    public bool Checked { get; set; }
    public string Details { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class ThoughtProcess
{
    [Required]
    public bool Coherent { get; set; }

    [Required]
    public bool Circumstantial { get; set; }

    [Required]
    public bool Tangential { get; set; }

    [Required]
    public bool Loa { get; set; }

    [Required]
    public bool Foi { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string ThoughtProcessOther { get; set; }
}

[If(nameof(OtherComment), true, nameof(OtherComment))]
public class InitialPsychiatricEvaluationYesOrNo
{
    [Required]
    public bool Yes { get; set; }

    [Required]
    public bool No { get; set; }

    [Required]
    public bool Plan { get; set; }

    [Required]
    public bool NoPlan { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(OtherComment))]
    public string OtherComment { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class MentalStatusExamAffect
{
    [Required]
    public bool FullRange { get; set; }

    [Required]
    public bool Constricted { get; set; }

    [Required]
    public bool Fearful { get; set; }

    [Required]
    public bool Blunted { get; set; }

    [Required]
    public bool Intense { get; set; }

    [Required]
    public bool Restricted { get; set; }

    [Required]
    public bool DetachedOrApathetic { get; set; }

    [Required]
    public bool Labile { get; set; }

    [Required]
    public bool Cheerful { get; set; }

    [Required]
    public bool Depressed { get; set; }

    [Required]
    public bool Anxious { get; set; }

    [Required]
    public bool Dull { get; set; }

    [Required]
    public bool Flat { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string MentalStatusExamAffectOther { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class MentalStatusExamMood
{
    [Required]
    public bool Anxious { get; set; }

    [Required]
    public bool Fearful { get; set; }

    [Required]
    public bool Apprehensive { get; set; }

    [Required]
    public bool Irritable { get; set; }

    [Required]
    public bool Apathetic { get; set; }

    [Required]
    public bool Passive { get; set; }

    [Required]
    public bool Cheerful { get; set; }

    [Required]
    public bool ElevatedMood { get; set; }

    [Required]
    public bool AshamedOrGuilty { get; set; }

    [Required]
    public bool Dysphoric { get; set; }

    [Required]
    public bool Angry { get; set; }

    [Required]
    public bool Neutral { get; set; }

    [Required]
    public bool Subdued { get; set; }

    [Required]
    public bool Hostile { get; set; }

    [Required]
    public bool Elated { get; set; }

    [Required]
    public bool ContentContextAppropriate { get; set; }

    [Required]
    public bool ContentContextInappropriate { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string MentalStatusExamMoodOther { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class MentalStatusExamAttitude
{
    [Required]
    public bool Cooperative { get; set; }

    [Required]
    public bool Suspicious { get; set; }

    [Required]
    public bool Guarded { get; set; }

    [Required]
    public bool Evasive { get; set; }

    [Required]
    public bool Tense { get; set; }

    [Required]
    public bool VolunteersLittleInfo { get; set; }

    [Required]
    public bool Grandiose { get; set; }

    [Required]
    public bool Positive { get; set; }

    [Required]
    public bool Resistant { get; set; }

    [Required]
    public bool Hostile { get; set; }

    [Required]
    public bool Uncooperative { get; set; }

    [Required]
    public bool Friendly { get; set; }

    [Required]
    public bool Relaxed { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string MentalStatusExamAttitudeOther { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class MentalStatusExamBehavior
{
    [Required]
    public bool Calm { get; set; }

    [Required]
    public bool Tearful { get; set; }

    [Required]
    public bool Aggressive { get; set; }

    [Required]
    public bool GoodEyeContact { get; set; }

    [Required]
    public bool PoorEyeContact { get; set; }

    [Required]
    public bool Uncooperative { get; set; }

    [Required]
    public bool Rebellious { get; set; }

    [Required]
    public bool AngryOutbursts { get; set; }

    [Required]
    public bool OverlyDramatic { get; set; }

    [Required]
    public bool Manipulate { get; set; }

    [Required]
    public bool Seductive { get; set; }

    [Required]
    public bool PsychomotorAgitation { get; set; }

    [Required]
    public bool Demanding { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string MentalStatusExamBehaviorOther { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class MentalStatusExamSpeech
{
    [Required]
    public bool PaucityOfSpeech { get; set; }

    [Required]
    public bool CannedSpeech { get; set; }

    [Required]
    public bool ScanningSpeech { get; set; }

    [Required]
    public bool SlurredSpeech { get; set; }

    [Required]
    public bool FluentSpeech { get; set; }

    [Required]
    public bool Articulate { get; set; }

    [Required]
    public bool Rapid { get; set; }

    [Required]
    public bool Normal { get; set; }

    [Required]
    public bool PressuredSpeech { get; set; }

    [Required]
    public bool Loud { get; set; }

    [Required]
    public bool Slurred { get; set; }

    [Required]
    public bool Slow { get; set; }

    [Required]
    public bool Whining { get; set; }

    [Required]
    public bool Inappropriate { get; set; }

    [Required]
    public bool ExcessiveProfanity { get; set; }

    [Required]
    public bool Confused { get; set; }

    [Required]
    public bool LooseAssociations { get; set; }

    [Required]
    public bool FlightOfIdeas { get; set; }

    [Required]
    public bool Neologisms { get; set; }

    [Required]
    public bool Tangential { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string MentalStatusExamSpeechOther { get; set; }
}

[If(nameof(OtherComments), true, nameof(OtherComments))]
public class MentalStatusExamAppearance
{
    [Required]
    public bool Neat { get; set; }

    [Required]
    public bool Disheveled { get; set; }

    [Required]
    public bool PoorlyGroomed { get; set; }

    [Required]
    public bool Malodorous { get; set; }

    [Required]
    public bool Flamboyant { get; set; }

    [Required]
    public bool WellGroomed { get; set; }

    [Required]
    public bool CasuallyDressed { get; set; }

    [Required]
    public bool Articulate { get; set; }

    [Required]
    public bool Relaxed { get; set; }

    [Required]
    public bool AgeAppropriate { get; set; }

    [Required]
    public bool ChronicallyIll { get; set; }

    [Required]
    public bool LittleFacialExpression { get; set; }

    [Required]
    public bool Emaciated { get; set; }

    [Required]
    public bool Seductive { get; set; }

    [Required]
    public bool Eccentric { get; set; }

    [Required]
    public bool Appropriate { get; set; }

    [Required]
    public bool Inappropriate { get; set; }

    [Required]
    public bool Obese { get; set; }

    [Required]
    public bool OtherComments { get; set; }

    [Required(ConditionGroup = nameof(OtherComments))]
    public string MentalStatusExamAppearanceOther { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class PertinentPastPsychiatricHistory
{
    [Required]
    public bool FailureOfOutPatientOrIopTreatment { get; set; }

    [Required]
    public bool HoViolenceToSelfOthersProperty { get; set; }

    [Required]
    public bool HoRecurrentProblemsWithPsychoActiveSubstances { get; set; }

    [Required]
    public bool HoPsychiatricHospitalizations { get; set; }

    [Required]
    public bool HoLegalProblems { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string OtherPertinentPastPsychiatricHistory { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum AdmissionType
{
    Voluntary,
    Involuntary
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MaritalStatus
{
    Married,
    Partnered,
    Separated,
    Divorced,
    Widowed,
    Single
}

public class InitialPsychiatricEvaluationAllergy
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

public class Medication
{
    public string MedicationName { get; set; }
    public string DozeStrength { get; set; }
    public string InventoryType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ScheduleType { get; set; }
    public int TotalInitialQuantity { get; set; }
    public int TakenQuantity { get; set; }
    public int TotalLeftQuantity { get; set; }
    public string Status { get; set; }
    public string Reason { get; set; }
    public string Notes { get; set; }
}