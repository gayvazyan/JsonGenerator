using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class GadSevenAnxietyScale
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
    public GedSevenAnxietyScale FeelingNervous { get; set; }
    [Required]
    public GedSevenAnxietyScale UnableToControlWorrying { get; set; }
    [Required]
    public GedSevenAnxietyScale WorryingTooMuch { get; set; }
    [Required]
    public GedSevenAnxietyScale TroubleRelaxing { get; set; }
    [Required]
    public GedSevenAnxietyScale Restlessness { get; set; }
    [Required]
    public GedSevenAnxietyScale EasilyAnnoyed { get; set; }
    [Required]
    public GedSevenAnxietyScale FeelingAfraid { get; set; }
    [Required]
    public GedSevenAnxietyScale DifficultyLevel { get; set; }
    [Required]
    public int Total { get; set; }

    public string ClinicalImpression { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum GedSevenAnxietyScale
{
    NotAtAll,
    SeveralDays,
    MoreThanHalfTheDays,
    NearlyEveryDay
}