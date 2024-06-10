using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class IntakeNutritionalScreen
{
    [Required]
    public DateTime EvaluationDate { get; set; }

    [Required]
    public string LastDayHoursEating { get; set; }

    [Required]
    public WeightChangeRate WeightChange { get; set; }

    public string EatingDisorderHistory { get; set; }
    public List<Allergy> Allergies { get; set; }

    [Required]
    public IntakeNutritionalScreenScore EatsFewerThenTwoMeals { get; set; }

    [Required]
    public IntakeNutritionalScreenScore EatsFewFruitsVegetablesMilkProducts { get; set; }

    [Required]
    public IntakeNutritionalScreenScore HasToothOrMouthProblems { get; set; }

    [Required]
    public IntakeNutritionalScreenScore EatsAloneMostOfTheTime { get; set; }

    [Required]
    public IntakeNutritionalScreenScore ComplainsOfBeingThirstyAllTheTime { get; set; }

    [Required]
    public IntakeNutritionalScreenScore ChronicDiarrhea { get; set; }

    [Required]
    public IntakeNutritionalScreenScore Constipation { get; set; }

    [Required]
    public IntakeNutritionalScreenScore NauseaOrVomiting { get; set; }

    [Required]
    public IntakeNutritionalScreenScore FrequentRefluxIndigestion { get; set; }

    [Required]
    public IntakeNutritionalScreenSimpleScore NonComplianceWithTherapeuticDiet { get; set; }

    [Required]
    public IntakeNutritionalScreenSimpleScore CurrentEatingDisorder { get; set; }

    [Required]
    public IntakeNutritionalScreenSimpleScore KnowledgeDeficitOfTherapeuticDiet { get; set; }

    [Required]
    public AppetiteScore Appetite { get; set; }

    [Required]
    public int TotalScore { get; set; }

    public bool ReferralToNutritionistOrPhysician { get; set; }
    public DateTime ReferralDate { get; set; }
}

public class Allergy
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

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum WeightChangeRate
{
    Stable,
    Loss,
    Gain
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum IntakeNutritionalScreenScore
{
    NoProblem,
    OccasionalProblem,
    FrequentOrDailyProblem
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum AppetiteScore
{
    Good,
    Fair,
    Poor
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum IntakeNutritionalScreenSimpleScore
{
    No,
    Yes
}