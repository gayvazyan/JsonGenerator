using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(CaseConference))]
[Description(nameof(CaseConference))]
[IfEnum(nameof(NeedToSign))]
public class CaseConference
{
    [Required]
    public string PatientName { get; set; }

    [Required]
    public string FilledBy { get; set; }

    [Required]
    public NeedToSign NeedToSign { get; set; }

    [Required(ConditionGroup = NeedToSign.OnlyDoctor)]
    [Required(ConditionGroup = NeedToSign.Both)]
    public string DoctorSignuture { get; set; }

    [Required(ConditionGroup = NeedToSign.OnlyPatient)]
    [Required(ConditionGroup = NeedToSign.Both)]
    public string PatientSignuture { get; set; }

    [Required]
    public List<TreatmentPlanSection> Sections { get; set; }

    public string Summary { get; set; }
}

[If(nameof(ProgressResolvingTreatmentPlanProblem), nameof(SectionOption.Other),
    nameof(ProgressResolvingTreatmentPlanProblem))]
[If(nameof(FollowingThroughWithGoalAndActionStep), nameof(SectionOption.Other),
    nameof(FollowingThroughWithGoalAndActionStep))]
public class TreatmentPlanSection
{
    [Required]
    public string TreatmentPlan { get; set; }

    [Required]
    public SectionOption ProgressResolvingTreatmentPlanProblem { get; set; }

    [Required(ConditionGroup = nameof(ProgressResolvingTreatmentPlanProblem))]
    public string ProgressResolvingTreatmentPlanProblemComment { get; set; }


    [Required]
    public SectionOption FollowingThroughWithGoalAndActionStep { get; set; }

    [Required(ConditionGroup = nameof(FollowingThroughWithGoalAndActionStep))]
    public string FollowingThroughWithGoalAndActionStepComment { get; set; }

    [Required]
    public string InterventionPlan { get; set; }

    public string RecommendationsAreGivenToClient { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SectionOption
{
    No,
    Minor,
    Significant,
    Reasoning,
    Other
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum NeedToSign
{
    OnlyPatient,
    OnlyDoctor,
    Both
}