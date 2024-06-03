using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(SlidingScaleFeeAssistanceProgramPolicy))]
[Description(nameof(SlidingScaleFeeAssistanceProgramPolicy))]
public class SlidingScaleFeeAssistanceProgramPolicy
{
    [Required]
    public string Company { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string TitleOfEmployeeAdministeringProgram { get; set; }
}