using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

public class DischargePlan
{
    [Required]
    public DateTime DateOfAdmission { get; set; }

    [Required]
    public DateTime DateOfDischarge { get; set; }

    [Required]
    public DischargeType Discharge { get; set; }

    [Required]
    public string LengthOfStay { get; set; }

    [Required]
    public string DischargeLocation { get; set; }

    [Required]
    public string WithWhom { get; set; }

    [Required]
    public string AddressAndTelephone { get; set; }

    [Required]
    public TransportationType Transportation { get; set; }

    [Required]
    public AftercareAppointmentsAndRecommendations AftercareAppointmentsAndRecommendations { get; set; }

    [Required]
    public AaNaInvolvementType AaNaInvolvement { get; set; }

    public string MeetingsCount { get; set; }

    [Required]
    public string WorkSchoolVocationalRehab { get; set; }

    [Required]
    public List<PersonalSupportSystemType> PersonalSupportSystems { get; set; }

    [Required]
    public string SummaryOfPlanAfterDischarge { get; set; }
}

public class AftercareAppointmentsAndRecommendations
{
    [Required]
    public SpecialistType Specialist { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string Phone { get; set; }

    [Required]
    public DateTime AppointmentDateTime { get; set; }
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum PersonalSupportSystemType
{
    Sponsor,
    Therapist,
    SoberFriend
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum AaNaInvolvementType
{
    ObtainASponsor,
    Stepwork,
    NumberOfMeetingsWeek
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum SpecialistType
{
    Psychiatrist,
    Md,
    Therapist,
    Other
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum TransportationType
{
    Self,
    RelativeOrFriend,
    Public,
    Facility,
    Other
}

[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
public enum DischargeType
{
    Completed,
    Aca,
    Transfer
}