using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(SlidingScaleFeeAssistanceProgramChart))]
[Description(nameof(SlidingScaleFeeAssistanceProgramChart))]
public class SlidingScaleFeeAssistanceProgramChart
{
    [Required]
    public string Company { get; set; }
}