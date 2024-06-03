using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(GuidelinesForDiscussingFinancialResponsibilityWithClients))]
[Description(nameof(GuidelinesForDiscussingFinancialResponsibilityWithClients))]
public class GuidelinesForDiscussingFinancialResponsibilityWithClients
{
    [Required]
    public string Comapany { get; set; }
}