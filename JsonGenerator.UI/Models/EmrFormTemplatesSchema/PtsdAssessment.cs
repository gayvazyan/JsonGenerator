using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class PtsdAssessment
{
    [Required]
    public DateTime EvaluationDate { get; set; }

    [Required]
    public PtsdAssessmentScore RepeatedMemories { get; set; }

    [Required]
    public PtsdAssessmentScore RepeatedDreams { get; set; }

    [Required]
    public PtsdAssessmentScore RelivingExperience { get; set; }

    [Required]
    public PtsdAssessmentScore UpsetWhenReminded { get; set; }

    [Required]
    public PtsdAssessmentScore PhysicalReactions { get; set; }

    [Required]
    public PtsdAssessmentScore AvoidThinking { get; set; }

    [Required]
    public PtsdAssessmentScore AvoidActivities { get; set; }

    [Required]
    public PtsdAssessmentScore TroubleRemembering { get; set; }

    [Required]
    public PtsdAssessmentScore LossOfInterest { get; set; }

    [Required]
    public PtsdAssessmentScore FeelingDistant { get; set; }

    [Required]
    public PtsdAssessmentScore EmotionallyNumb { get; set; }

    [Required]
    public PtsdAssessmentScore FutureCutShort { get; set; }

    [Required]
    public PtsdAssessmentScore TroubleSleeping { get; set; }

    [Required]
    public PtsdAssessmentScore Irritability { get; set; }

    [Required]
    public PtsdAssessmentScore DifficultyConcentrating { get; set; }

    [Required]
    public PtsdAssessmentScore SuperAlert { get; set; }

    [Required]
    public PtsdAssessmentScore JumpyOrStartled { get; set; }

    [Required]
    public int TotalScore { get; set; }

    [Required]
    public string Comment { get; set; }
}


[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PtsdAssessmentScore
{
    NotAtAll = 0,
    ALittleBit = 1,
    Moderately = 2,
    QuiteABit = 3,
    Extremely = 4
}