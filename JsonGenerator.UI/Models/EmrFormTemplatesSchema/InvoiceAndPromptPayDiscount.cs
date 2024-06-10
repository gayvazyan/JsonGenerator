using System;
using Json.Schema.Generation;

namespace JsonGenerator.UI.Models.EmrFormTemplatesSchema;

[Title(nameof(InvoiceAndPromptPayDiscount))]
[Description(nameof(InvoiceAndPromptPayDiscount))]
public class InvoiceAndPromptPayDiscount
{
    [Required]
    public string Company { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string ClientName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [Minimum(0)]
    public int AccountNumber { get; set; }

    [Required]
    public DateTime DateOfService { get; set; }

    [Required]
    public DateTime PaymentDueDate { get; set; }

    [Minimum(0)]
    public int TotalFacilityCharge { get; set; }

    [Minimum(0)]
    public int InsurancePayment { get; set; }

    [Minimum(0)]
    public int OtherPayment { get; set; }

    [Minimum(0)]
    public int EstimatedAmountYouOwe { get; set; }

    [Minimum(0)]
    public int DiscountOnBalanceIfReceivedBetweenFiveAndFifteenDays { get; set; }

    [Minimum(0)]
    public int DiscountOnBalanceIfReceivedBetweenSixteenAndTwentyNineDays { get; set; }
}