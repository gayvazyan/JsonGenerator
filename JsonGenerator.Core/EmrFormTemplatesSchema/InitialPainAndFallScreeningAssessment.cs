using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(InitialPainAndFallScreeningAssessment))]
[Description(nameof(InitialPainAndFallScreeningAssessment))]
[If(nameof(DoesItTravelAnywhereElseInBody), true, nameof(DoesItTravelAnywhereElseInBody))]
[If(nameof(IsReceivingTreatment), true, nameof(IsReceivingTreatment))]
public class InitialPainAndFallScreeningAssessment
{
    [Required]
    public DateTime EvaluationDate { get; set; }

    public string WhereIsThePain { get; set; }

    [Required]
    public PainDescription PainDescription { get; set; }

    [Required]
    public bool DoesItTravelAnywhereElseInBody { get; set; }

    [Required(ConditionGroup = nameof(DoesItTravelAnywhereElseInBody))]
    public string TravelLocation { get; set; }

    [Required]
    public string WhenDidItStart { get; set; }

    [Required]
    public string PainDuration { get; set; }

    [Required]
    public string PainTriggers { get; set; }

    [Required]
    public PainPersistence PainPersistence { get; set; }

    [Required]
    public bool IsReceivingTreatment { get; set; }

    [Required(ConditionGroup = nameof(IsReceivingTreatment))]
    public string TreatmentDetails { get; set; }

    [Required]
    public string PainReliefMethods { get; set; }

    [Required]
    public bool ReliefMethodWorks { get; set; }

    [Required]
    public PainScore PainScore { get; set; }

    [Required]
    public string DailyLifeImpact { get; set; }

    [Required]
    public string SleepingImpact { get; set; }

    [Required]
    public string EatingDrinkingImpact { get; set; }

    [Required]
    public string MoodImpact { get; set; }

    [Required]
    public string RelationshipsImpact { get; set; }

    [Required]
    public string SchoolImpact { get; set; }

    [Required]
    public string AddictionImpact { get; set; }

    [Required]
    public string PainGoal { get; set; }

    [Required]
    public string ReferralReason { get; set; }

    [Required]
    public string QualityOfLifeImpact { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PainScore
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten
}

public class PainPersistence
{
    [Required]
    public bool AlwaysThere { get; set; }

    [Required]
    public bool ComesAndGoes { get; set; }
}

public class PainDescription
{
    [Required]
    public bool Aching { get; set; }

    [Required]
    public bool Burning { get; set; }

    [Required]
    public bool Throbbing { get; set; }

    [Required]
    public bool Pulling { get; set; }

    [Required]
    public bool Dull { get; set; }

    [Required]
    public bool Sharp { get; set; }

    [Required]
    public bool Pressing { get; set; }

    [Required]
    public bool Pricking { get; set; }

    [Required]
    public bool Tingling { get; set; }

    [Required]
    public bool Stabbing { get; set; }

    [Required]
    public bool Numb { get; set; }

    [Required]
    public bool None { get; set; }
}