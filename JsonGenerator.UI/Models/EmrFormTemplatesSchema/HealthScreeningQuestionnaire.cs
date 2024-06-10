using System;
using System.ComponentModel.DataAnnotations;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

/// Guidance on creating json schema for EMR template forms
/// 1. Based on form create C# model classes that will be able to accommodate the data for the form
///    Remember to use "[Required]" attribute from "System.ComponentModel.DataAnnotations" namespace for required properties
/// 2. Use json schema generation tool (https://json-everything.net/json-schema/)
///    supplying the created model with "Generate a Schema" tool to get initial json schema for the form
/// 3. Add more validations to json schema based on the requirements using documentation (https://json-schema.org/understanding-json-schema/basics)
///    Most frequently you will need the conditional validations, it will look something like the example below
///   "allOf": [
///     {
///       "if": {
///         "properties": {
///           "HasPreviousTreatment": {
///             "const": false
///           }
///         }
///       },
///       "then": {
///        "required": [
///          "PreviousTreatments"
///        ]
///      }
///    ]
/// 4. Insert into DB
///     4.1 Create a row in "form_templates" table with the template form name
///     4.2 Using the "Id" from previous as the "templateId" table insert a row "emr_form_template_json_schema" with json schema
/// 5. Create a json from C# model classes to test and provide QA and Frontend teams to work with
///     5.1 For that you need to use use [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))] on enums
///         from namespace "Newtonsoft.Json.Converters"
///     5.2 Using libraries
///           <PackageReference Include="AutoBogus" Version="*" />
///           <PackageReference Include="Newtonsoft.Json" Version="*" />
///         Run the following code snippet
/// 
///             var fake = AutoBogus.AutoFaker.Generate<TModel>();
///             var fakeJson = JsonConvert.SerializeObject(fake, Formatting.Indented);
/// 
///         where "TModel" is the top level class in your model hierarchy         

public class HealthScreeningQuestionnaire
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string DateOfBirth { get; set; }

    [Required]
    public string Date { get; set; }

    public string HeartAttack { get; set; }
    public string ChestPain { get; set; }
    public string SeriousIllness { get; set; }
    public string PositiveForTuberculosis { get; set; }
    public string HivOrAidsTreatment { get; set; }
    public string SexuallyTransmittedDiseases { get; set; }
    public string HeadInjury { get; set; }
    public string Diabetes { get; set; }
    public string OpenWounds { get; set; }
    public string Seizure { get; set; }
    public string CpapUse { get; set; }
    public string Stroke { get; set; }

    [Required]
    public bool IsPregnant { get; set; }

    public string Trimester { get; set; }
    public string ReceivingPrenatalCare { get; set; }
    public string HasPreNatalComplications { get; set; }
    public string OtherIllness { get; set; }
    public string BloodClot { get; set; }
    public string HighBloodPressure { get; set; }

    public string HistoryOfCancer { get; set; }
    public string Allergy { get; set; }
    public string BowelOrColonProblems { get; set; }
    public string LiverIllness { get; set; }
    public string GlandularDisease { get; set; }
    public string LungDiseases { get; set; }
    public string KidneysOrBladderProblems { get; set; }
    public string BoneMuscleJointInjuries { get; set; }
    public string CounterPainMedications { get; set; }
    public string CounterDigestiveMedications { get; set; }
    public string GlassesOrHearingAids { get; set; }

    [Required]
    public string LastDentalExam { get; set; }

    public string NeedDentalCare { get; set; }
    public string DentalAppliances { get; set; }

    [Required]
    public string SurgeriesOrHospitalizations { get; set; }

    [Required]
    public string VisitPhysicianOrPsychiatrist { get; set; }

    public System.Collections.Generic.List<PastSevenDaysDrugUse> DrugUseInPastSevenDays { get; set; }
    public System.Collections.Generic.List<PastYearDrugUse> PastYearDrugUses { get; set; }
    public System.Collections.Generic.List<PrescriptionMedication> PrescriptionMedications { get; set; }

    [Required]
    public bool FeelingDown { get; set; }

    public string FeelingDownDetails { get; set; }
    public string TreatmentForPsychiatricDiagnosis { get; set; }
    public string LastTwoWeeksFeelingNervous { get; set; }
    public string LastTwoWeeksThoughtsOfSuicide { get; set; }
    public string LastTwoYearsAttemptsOfSuicide { get; set; }
    public string SelfHarm { get; set; }
    public string HearingOrSeeingThings { get; set; }

    [Required]
    public bool PartnerPushedOrSlapped { get; set; }

    public string PartnerPushedOrSlappedDetails { get; set; }
    public System.Collections.Generic.List<AlcoholismOrDrugAbuseRecoveryTreatment> AlcoholismOrDrugAbuseRecoveryTreatments { get; set; }

    [Required]
    public bool WithdrawalSymptomsTreatment { get; set; }

    public string WithdrawalSymptomsTreatmentDetails { get; set; }

    [Required]
    public ClientConsent InformedOfMedicationAssistedTreatment { get; set; }

    [Required]
    public ClientConsent ScreenedForUseOfTobacco { get; set; }

    public string AdditionalComments { get; set; }
}

public class PrescriptionMedication
{
    [Required]
    public string TypeOfDrug { get; set; }

    [Required]
    public string RouteOfAdministration { get; set; }
}

public class AlcoholismOrDrugAbuseRecoveryTreatment
{
    [Required]
    public string TypeOfPreviousTreatment { get; set; }

    [Required]
    public string NameOfPreviousTreatment { get; set; }

    [Required]
    public DateTime DateOfPreviousTreatment { get; set; }

    [Required]
    public bool TreatmentCompleted { get; set; }
}

public class ClientConsent
{
    [Required]
    public string ClientInitial { get; set; }

    [Required]
    public string StaffInitial { get; set; }
}