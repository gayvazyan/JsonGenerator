using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(ClinicalOpiateWithdrawalScale))]
[Description(nameof(ClinicalOpiateWithdrawalScale))]
public class ClinicalOpiateWithdrawalScale
{
    [Required]
    public string PatientName { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public bool WasThePatientSleepingAtTheTimeOfTheCowsAssessment { get; set; }

    [Required]
    public VitalSign VitalSigns { get; set; }

    [Required]
    [MinItems(1)]
    public List<OpiateWithdrawalRate> OpiateWithdrawalRates { get; set; }

    public string Comment { get; set; }
}

public class OpiateWithdrawalRate
{
    [Required]
    public string Time { get; set; }

    [Required]
    public RestingPulseRate RestingPulseRate { get; set; }

    [Required]
    public SweatingOverPastHalfHour SweatingOverPastHalfHour { get; set; }

    [Required]
    public RestlessnessObservation RestlessnessObservation { get; set; }

    [Required]
    public PupilSize PupilSize { get; set; }

    [Required]
    public BoneOrJointAche BoneOrJointAche { get; set; }

    [Required]
    public RunnyNoseOrTearing RunnyNoseOrTearing { get; set; }

    [Required]
    public GiUpset GiUpsetOverPastHalfHour { get; set; }

    [Required]
    public YawningObservation YawningObservation { get; set; }

    [Required]
    public TremorObservedOverOutstretchedHands TremorObservedOverOutstretchedHands { get; set; }

    [Required]
    public AnxietyOrIrritability AnxietyOrIrritability { get; set; }

    [Required]
    public GoosefleshSkin GoosefleshSkin { get; set; }

    [Required]
    [Minimum(0)]
    public int TotalScore { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum GoosefleshSkin
{
    SkinIsSmooth,
    PiloerectionOfSkinCanBeFeltOrHairsStandingUpOnArms,
    ProminentPiloerection
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum AnxietyOrIrritability
{
    None,
    PatientReportsIncreasingIrritabilityAnxiety,
    PatientObviouslyIrritableAnxious,
    PatientSoIrritableAnxiousThatAssessmentIsDifficult
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum TremorObservedOverOutstretchedHands
{
    NoTremor,
    TremorCanBeFeltButNotObserved,
    SlightTremorObserved,
    GrossTremorOrMuscleTwitching
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum YawningObservation
{
    NoYawning,
    YawningOnceOrTwiceDuringAssessment,
    YawningThreeOrMoreTimesDuringAssessment,
    YawningSeveralTimesPerMinute
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum GiUpset
{
    NoGiSymptoms,
    StomachCramps,
    NauseaOrLooseStool,
    VomitingOrDiarrhea,
    MultipleEpisodesOfVomitingOrDiarrhea
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum RunnyNoseOrTearing
{
    NotPresent,
    NasalStuffinessOrUnusuallyMoistEyes,
    NoseRunningOrTearing,
    NoseConstantlyRunningOrTearsStreamingDownCheeks
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum BoneOrJointAche
{
    NotPresent,
    MildDiffuseDiscomfort,
    PatientReportsSevereDiffuseAchesOfJointsMuscles,
    PatientIsRubbingJointsMusclesAndIsUnableToSitStillDueToDiscomfort
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PupilSize
{
    PupilsPinnedOrNormal,
    PupilsPossiblyLargerThanNormal,
    PupilsModeratelyDilated,
    PupilsSoDilatedThatOnlyTheRimOfTheIrisIsVisible
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum RestlessnessObservation
{
    AbleToSitStill,
    ReportsDifficultySittingStill,
    FrequentShiftingOrExtraneousMovementsOfLegsArms,
    UnableToSitStillForMoreThanAFewSeconds
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SweatingOverPastHalfHour
{
    NoRepeatOfChillsOrFlushing,
    SubjectiveReportOfChillsOrFlushing,
    FlushedOrObservableMoistnessOnFace,
    BeadsOfSweatOnBrowOrFace,
    SweatStreamingOfFace
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum RestingPulseRate
{
    BelowEighty,
    EightyOneToHundred,
    HundredOneToHundredTwenty,
    GreaterThanHundredTwenty
}