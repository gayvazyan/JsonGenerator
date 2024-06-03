using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(IncidentalMedicalServices))]
[Description(nameof(IncidentalMedicalServices))]
public class IncidentalMedicalServices
{
    [Required]
    public string HealthCarePractitionerName { get; set; }

    [Required]
    public string PatientName { get; set; }

    [Required]
    public string LocationName { get; set; }
}