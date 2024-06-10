using System;
using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(ColumbiaSuicideSeverityRatingScale))]
[Description(nameof(ColumbiaSuicideSeverityRatingScale))]
public class ColumbiaSuicideSeverityRatingScale
{
    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    public string Allergies { get; set; }

    [Required]
    public DateTime Admission { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    public bool WishToBeDead { get; set; }

    [Required]
    public bool CurrentSuicidalThoughts { get; set; }

    [Required]
    public bool SuicidalThoughtsMethod { get; set; }

    [Required]
    public bool SuicidalIntentWithoutSpecificPlan { get; set; }

    [Required]
    public bool SuicidalIntentWithPlan { get; set; }

    [Required]
    public bool AnyActionOfSuicidePastMonth { get; set; }

    [Required]
    public bool AnyActionOfSuicidePastMonthLifetime { get; set; }

    [Required]
    public ActivatingEventOption ActivatingEvent { get; set; }

    [Required]
    public TreatmentHistoryOption TreatmentHistory { get; set; }

    [Required]
    public OtherOption Other { get; set; }

    [Required]
    public ClinicalStatus ClinicalStatuses { get; set; }

    [Required]
    public bool AccessToLethalMethods { get; set; }

    [Required]
    public InternalProtectiveFactor InternalProtectiveFactors { get; set; }

    [Required]
    public ExternalProtectiveFactor ExternalProtectiveFactors { get; set; }

    [Required]
    public SuicidalIntent SuicidalIntent { get; set; }

    [Required]
    public RiskStratification RiskStratification { get; set; }

    [Required]
    public Triage Triage { get; set; }

    [Required]
    public Documentation Documentation { get; set; }
}

public class Documentation
{
    [Required]
    public RiskLevel RiskLevel { get; set; }

    [Required]
    public bool HasClinicalNote { get; set; }

    public string ClinicalNote { get; set; }

    [Required]
    public ClinicalNoteDirection ClinicalNoteDirections { get; set; }

    [Required]
    public string IntentWithPlan { get; set; }

    [Required]
    public string ClinicalStatus { get; set; }
}

public class ClinicalNoteDirection
{
    [Required]
    public bool YourClinicalObservation { get; set; }

    [Required]
    public bool RelevantMentalStatusInformation { get; set; }

    [Required]
    public bool MethodsOfSuicideRiskEvaluation { get; set; }

    [Required]
    public bool BriefEvaluationSummary { get; set; }

    [Required]
    public bool WarningSigns { get; set; }

    [Required]
    public bool RiskIndicators { get; set; }

    [Required]
    public bool ProtectiveFactors { get; set; }

    [Required]
    public bool AccessToLethalMeans { get; set; }

    [Required]
    public bool CollateralSourcesUsedAndRelevantInformationObtained { get; set; }

    [Required]
    public bool SpecificAssessmentDataToSupportRiskDetermination { get; set; }

    [Required]
    public bool RationaleForActionsTakenAndNotTaken { get; set; }

    [Required]
    public bool ProvisionOfCrisisLine { get; set; }

    [Required]
    public bool ImplementationOfSafetyPlan { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum RiskLevel
{
    HighSuicideRisk,
    ModerateSuicideRisk,
    LowSuicideRisk
}

public class Triage
{
    [Required]
    public FirstMultiOption FirstMultiOptions { get; set; }

    [Required]
    public SecondMultiOption SecondMultiOptions { get; set; }

    [Required]
    public ThirdMultiOption ThirdMultiOptions { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class ThirdMultiOption
{
    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool DiscretionaryReferral { get; set; }

    [Required]
    public bool NotApplicable { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class SecondMultiOption
{
    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool DirectlyAddressSuicideRiskImplementingSuicidePreventionStrategies { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool DevelopSafetyPlan { get; set; }

    [Required]
    public bool NotApplicable { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class FirstMultiOption
{
    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool InitiateLocalPsychiatricAdmissionProcess { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool StayWithPatientUntilTransferToHigherLevelOfCareIsComplete { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool FollowupAndDocumentOutcomeOfEmergencyPsychiatricEvaluation { get; set; }

    [Required]
    public bool NotApplicable { get; set; }
}

[If(nameof(NotApplicable), false, nameof(NotApplicable))]
public class OtherOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required(ConditionGroup = nameof(NotApplicable))]
    [MinItems(1, ConditionGroup = nameof(NotApplicable))]
    public List<string> Other { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class TreatmentHistoryOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool PreviousPsychiatricDiagnosisAndTreatments { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool HopelessOrDissatisfiedWithTreatment { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool NonCompliantWithTreatment { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool NotReceivingTreatment { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool Insomnia { get; set; }
}

public class RiskStratification
{
    [Required]
    public HighSuicideRiskOption HighSuicideRisk { get; set; }

    [Required]
    public ModerateSuicideRiskOption ModerateSuicideRisk { get; set; }

    [Required]
    public LowSuicideRiskOption LowSuicideRisk { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class HighSuicideRiskOption
{
    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool SuicideIdeationWithIntentOrIntentWithPlanInPastMonth { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool SuicidalBehaviorWithinPastThreeMonths { get; set; }

    [Required]
    public bool NotApplicable { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class ModerateSuicideRiskOption
{
    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool SuicideIdeationWithMethodWithoutPlanIntentOrBehaviorInPastMonth { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool SuicidalBehaviorMoreThanThreeMonthsAgo { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool MultipleRiskFactorsAndFewProtectiveFactors { get; set; }

    [Required]
    public bool NotApplicable { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class LowSuicideRiskOption
{
    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool SuicideIdeationWithoutMethodPlanIntentOrBehaviorInPastMonth { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool ModifiableRiskFactorsAndStrongProtectiveFactors { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool NoReportedHistoryOfSuicidalIdeationOrBehavior { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool NotApplicable { get; set; }
}

public class SuicidalIntent
{
    [Required]
    public SuicidalIntentFrequencyOption Frequency { get; set; }

    [Required]
    public SuicidalIntentDurationOption Duration { get; set; }

    [Required]
    public SuicidalIntentControllabilityOption Controllability { get; set; }

    [Required]
    public SuicidalIntentDeterrentOption Deterrent { get; set; }

    [Required]
    public SuicidalIntentReasonsForIdeationOption ReasonsForIdeation { get; set; }

    [Required]
    public int TotalScore { get; set; }
}

[If(nameof(NotApplicable), true, nameof(NotApplicable))]
public class ActivatingEventOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool RecentLossOrNegativeEvent { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool PendingIncarcerationOrHomelessness { get; set; }

    [Required]
    [Const(false, ConditionGroup = nameof(NotApplicable))]
    public bool CurrentOrPendingIsolation { get; set; }
}

[If(nameof(NotApplicable), false, nameof(NotApplicable))]
public class SuicidalIntentFrequencyOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required(ConditionGroup = nameof(NotApplicable))]
    public SuicidalIntentFrequency? FrequencyOption { get; set; }
}

[If(nameof(NotApplicable), false, nameof(NotApplicable))]
public class SuicidalIntentDurationOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required(ConditionGroup = nameof(NotApplicable))]
    public SuicidalIntentDuration? DurationOption { get; set; }
}

[If(nameof(NotApplicable), false, nameof(NotApplicable))]
public class SuicidalIntentDeterrentOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required(ConditionGroup = nameof(NotApplicable))]
    public SuicidalIntentDeterrent? DeterrentOption { get; set; }
}

[If(nameof(NotApplicable), false, nameof(NotApplicable))]
public class SuicidalIntentReasonsForIdeationOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required(ConditionGroup = nameof(NotApplicable))]
    public SuicidalIntentReasonsForIdeation? IdeationOption { get; set; }
}

[If(nameof(NotApplicable), false, nameof(NotApplicable))]
public class SuicidalIntentControllabilityOption
{
    [Required]
    public bool NotApplicable { get; set; }

    [Required(ConditionGroup = nameof(NotApplicable))]
    public SuicidalIntentControllability? ControllabilityOption { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SuicidalIntentReasonsForIdeation
{
    CompletelyToGetAttention,
    MostlyToGetAttention,
    EquallyToGetAttention,
    MostlyEndOrStopThePain,
    CompletelyToEndOrStopThePain,
    DoesNotApply
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SuicidalIntentDeterrent
{
    DeterrentsDefinitelyStoppedYouFromAttemptingSuicide,
    DeterrentsProbablyStoppedYou,
    UncertainThatDeterrentsStoppedYou,
    DeterrentsMostLikelyDidNotStopYou,
    DeterrentsDefinitelyDidNotStopYou,
    DoesNotApply
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SuicidalIntentControllability
{
    EasilyAbleToControlThoughts,
    CanControlThoughtsWithLittleDifficulty,
    CanControlThoughtWithSomeDifficulty,
    CanControlThoughtsWithALotOfDifficulty,
    UnableToControlThoughts,
    DoesNotAttemptToControlThoughts
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SuicidalIntentDuration
{
    Fleeting,
    SomeOfTheTime,
    ALotOfTime,
    MostOfDay,
    UnableToControlThoughts,
    DoesNotAttemptToControlThoughts
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SuicidalIntentFrequency
{
    LessThanOnceAWeek,
    OnceAWeek,
    TwoToFiveTimesInAWeek,
    DailyOrAlmostDaily,
    ManyTimesEachDay
}

public class ClinicalStatus
{
    [Required]
    public bool Hopelessness { get; set; }

    [Required]
    public bool MajorDepressiveEpisode { get; set; }

    [Required]
    public bool MixedAffectEpisode { get; set; }

    [Required]
    public bool CommandHallucinationsToHurtSelf { get; set; }

    [Required]
    public bool ChronicPhysicalPainOrOtherAcuteMedicalProblem { get; set; }

    [Required]
    public bool HighlyImpulsiveBehavior { get; set; }

    [Required]
    public bool SubstanceAbuseOrDependence { get; set; }

    [Required]
    public bool AgitationOrSevereAnxiety { get; set; }

    [Required]
    public bool PerceivedBurdenOnFamilyOrOthers { get; set; }

    [Required]
    public bool HomicidalIdeation { get; set; }

    [Required]
    public bool AggressiveBehaviorTowardsOthers { get; set; }

    [Required]
    public bool RefusesOrFeelsUnableToAgreeToSafetyPlan { get; set; }

    [Required]
    public bool SexualAbuse { get; set; }

    [Required]
    public bool FamilyHistoryOfSuicide { get; set; }
}

[If(nameof(Other), true, nameof(Other))]
public class InternalProtectiveFactor
{
    [Required]
    public bool FearOfDeathOrDyingDueToPainAndSuffering { get; set; }

    [Required]
    public bool IdentifiesReasonsForLiving { get; set; }

    [Required]
    public bool Other { get; set; }

    [Required(ConditionGroup = nameof(Other))]
    public string InternalProtectiveOtherFactor { get; set; }
}

public class ExternalProtectiveFactor
{
    [Required]
    public bool BeliefThatSuicideIsImmoral { get; set; }

    [Required]
    public bool ResponsibilityToFamilyOrOthers { get; set; }

    [Required]
    public bool SupportiveSocialNetworkOfFamilyOrFriends { get; set; }

    [Required]
    public bool EngagedInWorkOrSchool { get; set; }
}