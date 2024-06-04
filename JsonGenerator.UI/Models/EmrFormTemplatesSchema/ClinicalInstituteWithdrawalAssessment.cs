using Json.Schema.Generation;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(ClinicalInstituteWithdrawalAssessment))]
[Description(nameof(ClinicalInstituteWithdrawalAssessment))]
public class ClinicalInstituteWithdrawalAssessment
{
    [Required]
    public string PatientName { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Time { get; set; }

    [Required]
    public VitalSign VitalSigns { get; set; }

    [Required]
    public GradingToSeven NauseaAndVomiting { get; set; }

    [Required]
    public GradingToSeven TactileDisturbances { get; set; }

    [Required]
    public GradingToSeven Tremor { get; set; }

    [Required]
    public GradingToSeven AuditoryDisturbances { get; set; }

    [Required]
    public GradingToSeven ParoxysmalSweats { get; set; }

    [Required]
    public GradingToSeven VisualDisturbances { get; set; }

    [Required]
    public GradingToSeven Anxiety { get; set; }

    [Required]
    public GradingToSeven HeadacheFullnessInHead { get; set; }

    [Required]
    public GradingToSeven Agitation { get; set; }

    [Required]
    public GradingToFour OrientationAndCloudingOfSensorium { get; set; }

    [Required]
    [Minimum(0)]
    [Maximum(67)]
    public int TotalScore { get; set; }
}

public class VitalSign
{
    [Required]
    public DateTime Date { get; set; }

    [Required]
    [Maximum(400)]
    [Minimum(0)]
    public int BloodPressureSystolic { get; set; }

    [Required]
    [Maximum(100)]
    [Minimum(30)]
    public int BloodPressureDiastolic { get; set; }

    [Required]
    [Maximum(130)]
    [Minimum(50)]
    public int Temperature { get; set; }

    [Required]
    [Maximum(130)]
    [Minimum(50)]
    public int Pulse { get; set; }

    [Required]
    [Maximum(80)]
    [Minimum(0)]
    public int Respirations { get; set; }

    [Required]
    [Maximum(100)]
    [Minimum(70)]
    public int Saturation { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum GradingToSeven
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum GradingToFour
{
    One,
    Two,
    Three,
    Four
}