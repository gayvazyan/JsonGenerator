using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(HipaaNoticeOfPrivacyPractices))]
[Description(nameof(HipaaNoticeOfPrivacyPractices))]
public class HipaaNoticeOfPrivacyPractices
{
    [Required]
    [Minimum(0)]
    public int TelephoneNumber { get; set; }

    [Required]
    public DateTime EffectiveDate { get; set; }

    [Required]
    public string CorporateName { get; set; }

    [Required]
    public string AddressOne { get; set; }

    [Required]
    public string AddressTwo { get; set; }

    [Required]
    [Minimum(0)]
    public int PhoneNumber { get; set; }

    [Required]
    public string Email { get; set; }
}