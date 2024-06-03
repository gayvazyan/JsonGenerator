using System.ComponentModel.DataAnnotations;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

public class DepressionAssessment
{
    [Required]
    public DateTime EvaluationDate { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingBadOrSad { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingDiscouragedOrHopeless { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingLikeAFailure { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingDissatisfied { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingGuilty { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingOfBeingPunished { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingDisappointmentInThemselves { get; set; }

    [Required]
    public DepressionAssessmentScore BlamingThemselvesForEverything { get; set; }

    [Required]
    public DepressionAssessmentScore HavingDesireToKillThemselves { get; set; }

    [Required]
    public DepressionAssessmentScore DesireToCry { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingIrritated { get; set; }

    [Required]
    public DepressionAssessmentScore LostInterestInOtherPeople { get; set; }

    [Required]
    public DepressionAssessmentScore DisabilityToMakeDecisions { get; set; }

    [Required]
    public DepressionAssessmentScore DissatisfactionWithAppearance { get; set; }

    [Required]
    public DepressionAssessmentScore DisabilityToWork { get; set; }

    [Required]
    public DepressionAssessmentScore SleepDisorder { get; set; }

    [Required]
    public DepressionAssessmentScore FeelingTired { get; set; }

    [Required]
    public DepressionAssessmentScore AppetiteDisorder { get; set; }

    [Required]
    public DepressionAssessmentScore LoosingWeight { get; set; }

    [Required]
    public DepressionAssessmentScore WarringAboutPhysicalProblems { get; set; }

    [Required]
    public DepressionAssessmentScore SexualDisorder { get; set; }
    
    [Required]
    public int TotalScore { get; set; }
}

public enum DepressionAssessmentScore
{
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3
}