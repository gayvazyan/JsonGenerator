using Json.Schema.Generation;

namespace JsonGenerator.Core.EmrFormTemplatesSchema;

[Title(nameof(HousingPlanUponDischarge))]
[Description(nameof(HousingPlanUponDischarge))]
public class HousingPlanUponDischarge
{
    public string NameOfLandlord { get; set; }

    [Minimum(0)]
    public int PhoneNumberOfLandlord { get; set; }

    public string LandlordLocationOfResidence { get; set; }

    public string NameOfFamilyFriend { get; set; }

    [Minimum(0)]
    public int PhoneNumberOfFamilyFriend { get; set; }

    public string FamilyFriendLocationOfResidence { get; set; }

    [Required]
    public string NameOfGuarantorFamilyMember { get; set; }

    [Required]
    [Minimum(0)]
    public int GuarantorPhoneNumber { get; set; }

    [Required]
    public string ClientParentGuardianConservator { get; set; }

    [Required]
    public string ClientParentGuardianConservatorSignature { get; set; }

    [Required]
    public string ClientParentGuardianConservatorSignatureDate { get; set; }

    [Required]
    public string GuarantorFamilyMember { get; set; }

    [Required]
    public string GuarantorFamilyMemberSignature { get; set; }

    [Required]
    public string GuarantorFamilyMemberSignatureDate { get; set; }
}