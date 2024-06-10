using System;
using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(ResidentPersonalPropertyAcknowledgmentAndInventory))]
[Description(nameof(ResidentPersonalPropertyAcknowledgmentAndInventory))]
public class ResidentPersonalPropertyAcknowledgmentAndInventory
{
    [Required]
    public string NameOfProgram { get; set; }

    public List<PersonalProperty> PersonalPropertyInventory { get; set; }

    [Required]
    public string ResidentsName { get; set; }

    [Required]
    public string ResidentsSignature { get; set; }

    [Required]
    public DateTime ResidentsSignatureDate { get; set; }

    [Required]
    public string ProgramRepresentativeName { get; set; }

    [Required]
    public string ProgramRepresentativeSignature { get; set; }

    [Required]
    public DateTime ProgramRepresentativeSignatureDate { get; set; }
}

public class PersonalProperty
{
    [Required]
    public string ItemName { get; set; }

    [Required]
    public string Condition { get; set; }

    [Required]
    public string ItemDescription { get; set; }

    [Required]
    [Minimum(0)]
    public int Quantity { get; set; }

    [Required]
    public DateTime InitialDate { get; set; }
}