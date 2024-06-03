using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

public class BiopsychosocialAssessment
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string Allergies { get; set; }
    public DateTime Admission { get; set; }
    public string Location { get; set; }

    [Required]
    public DateTime DateTime { get; set; }

    [Required]
    public SocialArea SocialArea { get; set; }

    [Required]
    public LegalHistory LegalHistory { get; set; }

    [Required]
    public EducationalHistory EducationalHistory { get; set; }

    [Required]
    public EmploymentHistory EmploymentHistory { get; set; }

    [Required]
    public MilitaryHistory MilitaryHistory { get; set; }

    [Required]
    public SexualHistory SexualHistory { get; set; }

    [Required]
    public AbuseHistory AbuseHistory { get; set; }

    [Required]
    public TraumaHistory TraumaHistory { get; set; }

    [Required]
    public LeisureActivity LeisureActivity { get; set; }

    [Required]
    public CurrentFinancialStatus CurrentFinancialStatus { get; set; }

    [Required]
    public AddictionAndRelapseHistory AddictionAndRelapseHistory { get; set; }

    [Required]
    public ChemicalDependencyHistory ChemicalDependencyHistory { get; set; }

    [Required]
    public OtherAddictiveDisorderAssessment OtherAddictiveDisorderAssessment { get; set; }

    [Required]
    public string TreatmentHistory { get; set; }

    [Required]
    public TreatmentAcceptance TreatmentAcceptance { get; set; }

    [Required]
    public RecoveryEnvironment RecoveryEnvironment { get; set; }

    [Required]
    public SpiritualityAssessment SpiritualityAssessment { get; set; }

    [Required]
    public StrengthsAndLiabilitiesForRecovery StrengthsAndLiabilitiesForRecovery { get; set; }
}

public class StrengthsAndLiabilitiesForRecovery
{
    [Required]
    public List<string> Strengths { get; set; }

    [Required]
    public List<string> Liabilities { get; set; }

    [Required]
    public string ReasonAndGoalForTreatment { get; set; }

    [Required]
    public MentalStatusAssessment MentalStatusAssessments { get; set; }

    [Required]
    public LevelsOfImpairment LevelsOfImpairment { get; set; }

    [Required]
    public string RationaleForTreatmentAtThisLevelOfCare { get; set; }

    [Required]
    public string IntegratedDiagnosticSummary { get; set; }

    [Required]
    public string DsmFiveDiagnosis { get; set; }
}

public class LevelsOfImpairment
{
    [Required]
    public RatingSeverity DrugOrAlcohol { get; set; }

    [Required]
    public RatingSeverity EmploymentVocational { get; set; }

    [Required]
    public RatingSeverity Education { get; set; }

    [Required]
    public RatingSeverity Legal { get; set; }

    [Required]
    public RatingSeverity Psychosocial { get; set; }

    [Required]
    public RatingSeverity Medical { get; set; }

    [Required]
    public RatingSeverity MentalHealth { get; set; }

    [Required]
    public RatingSeverity OverallLevelOfImpairmentAndSeverity { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum RatingSeverity
{
    NotAtAll = 0,
    Slightly = 1,
    Moderately = 2,
    Considerably = 3,
    Extremely = 4
}

public class MentalStatusAssessment
{
    [Required]
    public List<Appearance> Appearance { get; set; }

    [Required]
    public List<Affect> Affect { get; set; }

    [Required]
    public List<Mood> Mood { get; set; }

    [Required]
    public List<Behavior> Behavior { get; set; }

    [Required]
    public List<Orientation> Orientation { get; set; }

    [Required]
    public List<Insight> Insight { get; set; }

    [Required]
    public List<Judgment> Judgment { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Appearance
{
    CleanNeat,
    DisheveledUnkempt
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Affect
{
    Appropriate,
    Inappropriate,
    Flat
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Mood
{
    Happy,
    Sad,
    Angry,
    Depressed,
    Labile,
    Anxious
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Behavior
{
    Cooperative,
    Uncooperative
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Orientation
{
    None,
    Person,
    Time,
    Place
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Insight
{
    Good,
    Fair,
    Poor
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum Judgment
{
    Mature,
    Immature
}

public class SpiritualityAssessment
{
    [Required]
    public bool UsePrayerOrMeditation { get; set; }

    public string PrayerOrMeditationDescription { get; set; }

    [Required]
    public string ExpressSpirituality { get; set; }

    [Required]
    public string StrengthAndHopeProvider { get; set; }

    [Required]
    public string PhilosophyOfLife { get; set; }

    [Required]
    public bool HasSpiritualGoals { get; set; }

    public string SpiritualGoalsDescription { get; set; }

    [Required]
    public bool HasSpecificReligiousPractice { get; set; }

    public string SpecificReligiousPracticeDescription { get; set; }

    [Required]
    public string ImportanceOfChurchOrSynagogue { get; set; }

    [Required]
    public bool SpiritualSupportDesired { get; set; }

    public string DesiredSpiritualSupportDescription { get; set; }

    [Required]
    public string ImportanceOfBeliefInGod { get; set; }

    [Required]
    public string FaithInCopingWithProblems { get; set; }

    [Required]
    public string DrugOfChoiceImpactOnValues { get; set; }

    [Required]
    public string ImpactOnSelfWorth { get; set; }
}

public class RecoveryEnvironment
{
    [Required]
    public string SupportiveRelationships { get; set; }

    [Required]
    public string LivingSituation { get; set; }

    [Required]
    public bool EngagesInSubstanceFreeLeisureActivities { get; set; }

    public string EngagesInSubstanceFreeLeisureActivityDescription { get; set; }

    [Required]
    public string SupportNeeds { get; set; }

    [Required]
    public bool IsAnyoneUsingDrugsOrAlcohol { get; set; }

    public string RelationshipDescription { get; set; }

    [Required]
    public bool IsInUnsafeRelationship { get; set; }

    public string UnsafeRelationshipDescription { get; set; }
    public string AdditionalInformation { get; set; }
}

public class TreatmentAcceptance
{
    [Required]
    public bool IsExternallyMotivatedForTreatment { get; set; }

    public string ExternalMotivation { get; set; }

    [Required]
    public bool IsInternallyMotivatedForTreatment { get; set; }

    public string InternalMotivation { get; set; }

    [Required]
    public string RelapseOrContinuedUsePotential { get; set; }

    [Required]
    public string HelpForRecovery { get; set; }

    [Required]
    public List<ClientsStrength> ClientsStrengths { get; set; }

    [Required]
    public List<ClientsWeakness> ClientsWeaknesses { get; set; }

    [Required]
    public List<TreatmentBarrier> TreatmentBarriers { get; set; }

    public string ExternalForces { get; set; }
    public string Other { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum TreatmentBarrier
{
    MedicalCondition,
    DrugUsingFriendsFamily,
    NoHousingToReturnTo,
    Unemployed,
    PsychiatricDiagnosis,
    Financial,
    OutsideObligations,
    Language,
    Cultural,
    FamilyPressures,
    ExternalForces,
    Other
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum ClientsWeakness
{
    LacksCopingSkills,
    PoorImpulseControl,
    InabilityToFormRelationships,
    LowSelfEsteem,
    MultipleTreatmentFailures,
    GriefLossIssues,
    PoorMotivation,
    TraumaAbuseIssues
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum ClientsStrength
{
    WillingnessToSeekTreatment,
    HasFinancialSupport,
    HasOutsideSupportSystem,
    WillingnessToComplyWithTreatment,
    AbilityToBenefitFromTreatment,
    IntrinsicallyMotivated,
    GoodPhysicalHealth,
    GoodCommunicationSkills,
    Employed,
    SoberFamilyOrFriendSupportSystem,
    Cooperative
}

public class OtherAddictiveDisorderAssessment
{
    [Required]
    public List<EatingDisorder> EatingDisorders { get; set; }

    [Required]
    public bool HasReceivedTreatmentForEatingDisorder { get; set; }

    [Required]
    public bool IsEatingDisorderAnIssueNow { get; set; }

    [Required]
    public bool HasHistoryOfGambling { get; set; }

    public bool GamblingDescription { get; set; }

    [Required]
    public bool IsGamblingAnIssue { get; set; }

    [Required]
    public bool HasOtherAddictiveDisorders { get; set; }

    public bool OtherAddictiveDisorderDescription { get; set; }

    [Required]
    public bool HasOtherAddictiveBehaviors { get; set; }

    public bool OtherAddictiveBehaviorDescription { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum EatingDisorder
{
    Anorexia,
    Nervosa,
    Bulimia,
    OverEating,
    Denied
}

public class ChemicalDependencyHistory
{
    [Required]
    public bool HasChemicalDependency { get; set; }

    public string When { get; set; }

    public string Where { get; set; }

    [Required]
    public List<SubstanceHistory> SubstanceHistories { get; set; }

    [Required]
    public bool OtherDrugUse { get; set; }

    public List<OtherDrugUse> OtherDrugUses { get; set; }

    [Required]
    public List<PastSevenDaysDrugUse> DrugUseInPastSevenDays { get; set; }

    [Required]
    public List<PastYearDrugUse> PastYearDrugUses { get; set; }

    [Required]
    public TopThreeDrugsOfChoice TopThreeDrugsOfChoice { get; set; }

    [Required]
    public string LengthOfLastRun { get; set; }

    [Required]
    public string LastDrugUsed { get; set; }

    [Required]
    public string PastTenDaysUsage { get; set; }

    [Required]
    public int AgeOfFirstUse { get; set; }

    [Required]
    public string LengthOfCurrentProblem { get; set; }

    [Required]
    public int CravingLevel { get; set; }

    [Required]
    public string CurrentlyLivingWith { get; set; }

    [Required]
    public string AlcoholDrugUse { get; set; }

    [Required]
    public string SupportiveInTreatment { get; set; }

    [Required]
    public bool PreviousTreatment { get; set; }

    public List<PreviousTreatment> PreviousTreatments { get; set; }

    [Required]
    public string TimeAbstinentFromEachPriorTreatment { get; set; }

    [Required]
    public string LongestPeriodOfSobriety { get; set; }

    [Required]
    public string PrecipitatingEventsToRelapse { get; set; }
}

public class AddictionAndRelapseHistory
{
    [Required]
    public string AddictionAndRelapseHistoryDescription { get; set; }

    [Required]
    public string ControlOrCutDownAlcoholOrDrugUseAttempts { get; set; }
}

public class CurrentFinancialStatus
{
    [Required]
    public string CurrentFinancialStatusDescription { get; set; }

    [Required]
    public string PaymentForDrugOrAlcoholAddiction { get; set; }
}

public class LeisureActivity
{
    [Required]
    public string LeisureActivities { get; set; }

    [Required]
    public string SubstanceAbuseEffectOnLeisure { get; set; }

    [Required]
    public List<LeisureAffectingProblem> LeisureAffectingProblems { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum LeisureAffectingProblem
{
    Job,
    Money,
    LackOfTime,
    Transportation,
    Apathy,
    PhysicalLimitations,
    Other
}

public class TraumaHistory
{
    [Required]
    public bool DeathOfFamilyMemberOrFriend { get; set; }

    [Required]
    public bool Exploitation { get; set; }

    [Required]
    public bool WitnessedAccident { get; set; }

    [Required]
    public bool CommunityViolence { get; set; }

    [Required]
    public bool DomesticViolence { get; set; }

    [Required]
    public bool ChildhoodTrauma { get; set; }

    [Required]
    public bool NaturalDisaster { get; set; }

    [Required]
    public bool FamilyViolence { get; set; }

    [Required]
    public bool Neglect { get; set; }

    [Required]
    public bool AnyPhysicalSexualEmotionalAbuse { get; set; }

    [Required]
    public bool SchoolViolence { get; set; }

    public string TraumaDescription { get; set; }

    public string PastTraumaInterferenceDescription { get; set; }

    [Required]
    public BiopsychosocialAssessmentYesOrNo IsPastTraumaRelatedToDrugOrAlcohol { get; set; }
}

public class AbuseHistory
{
    [Required]
    public bool IsVerballyAbused { get; set; }

    public string VerballyAbusedBy { get; set; }

    [Required]
    public bool IsEmotionallyAbused { get; set; }

    public string EmotionallyAbusedBy { get; set; }

    [Required]
    public bool IsPhysicallyAbused { get; set; }

    public string PhysicallyAbusedBy { get; set; }

    [Required]
    public bool IsSexuallyAbused { get; set; }

    public string SexuallyAbusedBy { get; set; }

    [Required]
    public bool IsNeglected { get; set; }

    public string NeglectedBy { get; set; }

    [Required]
    public bool IsAbandoned { get; set; }

    public string AbandonedBy { get; set; }

    [Required]
    public bool NonApply { get; set; }

    [Required]
    public bool AnyAbusiveRelationship { get; set; }

    public string AbusiveRelationshipDescription { get; set; }
}

public class SexualHistory
{
    [Required]
    public int LossOfVirginityAge { get; set; }

    [Required]
    public bool WasLossOfVirginityConsensual { get; set; }

    public string LossOfVirginityAdditionalInfo { get; set; }

    [Required]
    public SexualOrientation SexualOrientation { get; set; }

    public bool HasTheSameSexualOrientation { get; set; }
    public bool HasHistoryOfSexualAbuse { get; set; }
    public bool HasHistoryOfSexualMolestation { get; set; }
    public bool HasHistoryOfBeingInvolvedInProstitution { get; set; }
    public bool HasHistoryOfBeingRaped { get; set; }
    public bool HasHistoryOfIllegalSexualActs { get; set; }
    public bool HasHistoryOfBeingInvolvedInIncestuousRelationship { get; set; }
    public bool HasHistoryOfGenderIdentificationIssues { get; set; }
    public bool HasHistoryOfUnsafeSex { get; set; }
    public bool HasHistoryOfHivRiskyBehaviors { get; set; }
    public bool NonApply { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SexualOrientation
{
    Asexual,
    Heterosexual,
    Bisexual,
    Homosexual,
    Other
}

public class MilitaryHistory
{
    [Required]
    public bool HasServedInMilitary { get; set; }

    public string Branch { get; set; }
    public string LengthOfService { get; set; }
    public string DischargeType { get; set; }
    public string BenefitsReceived { get; set; }
    public string AdditionalInformation { get; set; }
}

public class EmploymentHistory
{
    public bool Assessment { get; set; }
    public DateTime DateOfAssessment { get; set; }

    [Required]
    public bool IsCurrentlyEmployed { get; set; }

    [Required]
    public bool HasEverBeenEmployed { get; set; }

    public List<Employments> Employments { get; set; }

    [Required]
    public bool DoesNeedSpecialVocationTraining { get; set; }

    public string WantedSpecialVocationTrainingDescription { get; set; }

    [Required]
    public bool HasReceivedSpecialVocationTraining { get; set; }

    public string ReceivedSpecialVocationTrainingDescription { get; set; }
}

public class Employments
{
    public string Position { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ReasonForLeaving { get; set; }
    public string Salary { get; set; }
}

public class EducationalHistory
{
    [Required]
    public bool Referral { get; set; }

    public DateTime DateOfReferral { get; set; }

    [Required]
    public DiplomaType DoesClientHaveDiploma { get; set; }

    [Required]
    public string HighestGradeCompleted { get; set; }

    [Required]
    public bool IsCurrentlyEnrolledInSchool { get; set; }

    public string CurrentEnrollmentDescription { get; set; }

    [Required]
    public bool HasBeenSuspendedOrExpelledInLastTwoYears { get; set; }

    public string SuspendedOrExpelledDescription { get; set; }

    [Required]
    public bool HasHistoryOfSpecialEducation { get; set; }

    public string SpecialEducationDescription { get; set; }

    [Required]
    public bool HasFutureEducationalGoals { get; set; }

    public string FutureEducationalGoalsDescription { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum DiplomaType
{
    HighSchoolDiploma,
    Ged,
    None
}

public class LegalHistory
{
    [Required]
    public bool IsInvolvedInLegalSystem { get; set; }

    public string LegalSystemInvolvementDescription { get; set; }

    [Required]
    public bool HasHistoryOfCriminalJusticeInvolvement { get; set; }

    public string CriminalJusticeInvolvementDescription { get; set; }
    public int AgeOfFirstInvolvement { get; set; }

    [Required]
    public bool HasClientBeenIncarcerated { get; set; }

    public List<IncarcerationHistory> IncarcerationHistories { get; set; }

    [Required]
    public bool DoesClientOweRestitution { get; set; }

    public string OwedRestitutionDescription { get; set; }

    [Required]
    public bool IsLegalAssessment { get; set; }

    public string LegalAssessmentDescription { get; set; }
}

public class SocialArea
{
    [Required]
    public FamilyOfOrigin FamilyOfOrigin { get; set; }

    [Required]
    public FamilyOfChoice FamilyOfChoice { get; set; }

    [Required]
    public CulturalInfluence CulturalInfluence { get; set; }

    [Required]
    public ClientInteractionProblem ClientInteractionProblem { get; set; }

    public string AdditionalInformation { get; set; }
}

public class ClientInteractionProblem
{
    public bool IsLoner { get; set; }
    public bool IsShy { get; set; }
    public bool HasDifficultyWithFriendships { get; set; }
    public bool IsFriendshipsAboutUseOfSubstance { get; set; }
    public bool IsLackingSoberRelationships { get; set; }
    public bool HasFewOrNoFriends { get; set; }
    public bool IsIsolatedDuringPeriodsOfUse { get; set; }
    public bool IsAngryDuringPeriodsOfUse { get; set; }
    public bool IsAggressiveDuringPeriodsOfUse { get; set; }
    public bool HasSymptomsOfSocialAnxiety { get; set; }
    public bool HasSymptomsOfParanoia { get; set; }
    public bool HasSymptomsOfDepression { get; set; }
    public bool HasDifficultyTrustingOthers { get; set; }
    public bool HasLowSelfEsteem { get; set; }
    public bool HasHistoryOfCoDependentRelationships { get; set; }
    public bool IsPreoccupiedWithPerceptionOfOthers { get; set; }
    public bool IsCriticalOfOthers { get; set; }
    public bool HasHistoryOfEndingRelationships { get; set; }
    public bool HasHistoryOfDomesticViolence { get; set; }
    public bool HasHistoryOfInappropriateSexualBoundaries { get; set; }
    public bool IsEngagingInBehaviorsThatEndangerOthers { get; set; }
    public string[] CustomProblem { get; set; }
}

public class FamilyOfOrigin
{
    [Required]
    public string RaisedData { get; set; }

    [Required]
    public bool HasSiblings { get; set; }

    public List<ClientSibling> Siblings { get; set; }

    [Required]
    public string HowFamilyGetsAlong { get; set; }

    [Required]
    public string WhoIsClosest { get; set; }

    [Required]
    public bool HasFamilyHistory { get; set; }

    public List<FamilyHistory> FamilyHistories { get; set; }
}

public class FamilyOfChoice
{
    [Required]
    public bool IsInvolvedInRelationship { get; set; }

    public string RelationshipDescription { get; set; }
    public string RelationshipWithPartnerDescription { get; set; }

    [Required]
    public bool HasChildren { get; set; }

    public ClientChildren ClientChildren { get; set; }
    public string RelationshipWithChildrenDescription { get; set; }
}

public class CulturalInfluence
{
    [Required]
    public bool HasCulturalInfluence { get; set; }

    public string CulturalInfluenceDescription { get; set; }
}

public class ClientChildren
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public string ParticipatoryParent { get; set; }
}

public class FamilyHistory
{
    public FamilyMember FamilyMember { get; set; }
    public string SubstanceUse { get; set; }
    public string MentalHealth { get; set; }
    public string CriminalInvolvement { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum FamilyMember
{
    Mother,
    Father,
    StepParent,
    Sibling,
    Children,
    CurrentPartner,
    PastPartner,
}

public class ClientSibling
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool GrewUpTogether { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum BiopsychosocialAssessmentYesOrNo
{
    Yes = 0,
    No = 1,
    Na = 2,
}