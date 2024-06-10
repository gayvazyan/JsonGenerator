using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class InitialDrugScreenClientConsentAndResults
{
    [Required]
    public DateTime DateOfCollection { get; set; }

    [Required]
    public string Breathalyzer { get; set; }

    [Required]
    public string Temperature { get; set; }

    [Required]
    public System.Collections.Generic.List<DrugScreen> DrugScreenResults { get; set; }

    public string DrugScreenResultOther { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum DrugScreen
{
    AllNegative,
    Bzo,
    Bar,
    Coc,
    Thc,
    Met,
    Opi,
    Mtd,
    Tca,
    Oxy,
    Mdma,
    Pcp,
    Amp,
    Bup,
    Other,
    OtherDescription,
}