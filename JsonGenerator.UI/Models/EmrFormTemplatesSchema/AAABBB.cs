using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(AAABBB))]
[Description(nameof(AAABBB))]
public class AAABBB
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Activites { get; set; }

    [Required]
    public string ClientName { get; set; }

    [Required]
    public string ClientSignatureUrl { get; set; }

    [Required]
    public DateTime ClientSignatureDate { get; set; }

    [Required]
    public string GuardianName { get; set; }

    [Required]
    public string GuardianSignatureUrl { get; set; }

    [Required]
    public DateTime GuardianSignatureDate { get; set; }
}