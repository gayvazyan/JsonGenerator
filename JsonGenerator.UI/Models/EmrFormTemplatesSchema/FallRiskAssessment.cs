using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class FallRiskAssessment
{
    [Required]
    public DateTime Birthdate { get; set; }

    [Required]
    public string Allergy { get; set; }

    [Required]
    public DateTime Admission { get; set; }

    [Required]
    public string Location { get; set; }

    [Required]
    public DateTime OpeningDateAndTime { get; set; }

    [Required]
    public MobilityScore Mobility { get; set; }

    [Required]
    public MentationScore Mentation { get; set; }

    [Required]
    public EliminationScore Elimination { get; set; }

    [Required]
    public PriorFallHistoryScore PriorFallHistory { get; set; }

    [Required]
    public CurrentMedicationsScore CurrentMedications { get; set; }

    [Required]
    public int Total { get; set; }

    [Required]
    public bool Notes { get; set; }

    public string Comment { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MobilityScore
{
    AmbulatesWithoutGaitDisturbance,
    AmbulatesOrTransfersWithAssistiveDevices,
    AmbulatesWithUnsteadyGaitAndNoAssistance,
    UnableToAmbulateOrTransfer
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum MentationScore
{
    AlertAndOrientedX3,
    PeriodicConfusion,
    ConfusionAtAllTimes,
    ComatoseOrUnresponsive
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum EliminationScore
{
    IndependentInElimination,
    IndependentWithFrequencyOrDiarrhea,
    NeedsAssistanceWithToileting,
    Incontinence
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PriorFallHistoryScore
{
    None,
    Unknown,
    YesBeforeAdmission,
    YesDuringAdmission
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum CurrentMedicationsScore
{
    No,
    Yes
}