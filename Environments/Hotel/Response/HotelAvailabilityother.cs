using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Hotel.Response
{
    public class AcceptedCreditCard
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [JsonObject("Amount")]
    public class HotelAvailability_Amount
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("CurrencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("Base")]
        public double Base { get; set; }

        [JsonProperty("Taxes")]
        public Taxes Taxes { get; set; }

        [JsonProperty("Total")]
        public double? Total { get; set; }

        [JsonProperty("Fees")]
        public Fees Fees { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    [JsonObject("AverageNightlyRate")]
    public class HotelAvailability_AverageNightlyRate
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("approximateInd")]
        public bool ApproximateInd { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    [JsonObject("BedConfiguration")]
    public class HotelAvailability_BedConfiguration
    {
        [JsonProperty("bedType")]
        public string BedType { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    [JsonObject("CancelPenalty")]
    public class HotelAvailability_CancelPenalty
    {
        [JsonProperty("@type")]
        public string atType { get; set; }

        [JsonProperty("Deadline")]
        public Deadline Deadline { get; set; }

        [JsonProperty("HotelPenalty")]
        public HotelPenalty HotelPenalty { get; set; }

        [JsonProperty("Refundable")]
        public string Refundable { get; set; }
    }

    [JsonObject("CatalogOffering")]
    public class HotelAvailability_CatalogOffering
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("Identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("ProductOptions")]
        public List<ProductOption> ProductOptions { get; set; }

        [JsonProperty("Price")]
        public Price Price { get; set; }

        [JsonProperty("TermsAndConditions")]
        public TermsAndConditions TermsAndConditions { get; set; }
    }

    [JsonObject("CatalogOfferings")]
    public class HotelAvailability_CatalogOfferings
    {
        [JsonProperty("@type")]
        public string atType { get; set; }

        [JsonProperty("CatalogOffering")]
        public List<CatalogOffering> CatalogOffering { get; set; }
    }

    [JsonObject("CatalogOfferingsHospitalityResponse")]
    public class HotelAvailability_CatalogOfferingsHospitalityResponse
    {
        [JsonProperty("@type")]
        public string atType { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("CatalogOfferings")]
        public CatalogOfferings CatalogOfferings { get; set; }

        [JsonProperty("ReferenceList")]
        public List<ReferenceList> ReferenceList { get; set; }
    }

    [JsonObject("Commission")]
    public class HotelAvailability_Commission
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("Percent")]
        public int Percent { get; set; }
    }

    [JsonObject("CurrencyCode")]
    public class HotelAvailability_CurrencyCode
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [JsonObject("DateRange")]
    public class HotelAvailability_DateRange
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    [JsonObject("Deadline")]
    public class HotelAvailability_Deadline
    {
        [JsonProperty("@type")]
        public string atType { get; set; }

        [JsonProperty("SpecificDate")]
        public SpecificDate SpecificDate { get; set; }

        [JsonProperty("Time")]
        public string Time { get; set; }
    }

    [JsonObject("Description")]
    public class HotelAvailability_Description
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("languages")]
        public List<object> Languages { get; set; }
    }

    public class Fee
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("feeCode")]
        public string FeeCode { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("feeApplication")]
        public string FeeApplication { get; set; }

        [JsonProperty("feeFrequency")]
        public string FeeFrequency { get; set; }

        [JsonProperty("FeeAmountOrPercent")]
        public FeeAmountOrPercent FeeAmountOrPercent { get; set; }
    }

    public class FeeAmountOrPercent
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }
    }

    public class Fees
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Fee")]
        public List<Fee> Fee { get; set; }
    }

    [JsonObject("Guarantee")]
    public class HotelAvailability_Guarantee
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("guaranteeType")]
        public string GuaranteeType { get; set; }
    }

    [JsonObject("HotelPenalty")]
    public class HotelAvailability_HotelPenalty
    {
        [JsonProperty("@type")]
        public string atType { get; set; }

        [JsonProperty("Amount")]
        public List<Amount> Amount { get; set; }

        [JsonProperty("Nights")]
        public int? Nights { get; set; }
    }

    [JsonObject("Identifier")]
    public class HotelAvailability_Identifier
    {
        [JsonProperty("authority")]
        public string Authority { get; set; }
    }

    [JsonObject("NightlyRate")]
    public class HotelAvailability_NightlyRate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("nights")]
        public int Nights { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }
    }

    [JsonObject("Price")]
    public class HotelAvailability_Price
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("CurrencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("Base")]
        public double Base { get; set; }

        [JsonProperty("TotalTaxes")]
        public double TotalTaxes { get; set; }

        [JsonProperty("TotalFees")]
        public int TotalFees { get; set; }

        [JsonProperty("TotalPrice")]
        public double TotalPrice { get; set; }

        [JsonProperty("PriceBreakdown")]
        public List<PriceBreakdown> PriceBreakdown { get; set; }
    }

    [JsonObject("PriceBreakdown")]
    public class HotelAvailability_PriceBreakdown
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roomPricingType")]
        public string RoomPricingType { get; set; }

        [JsonProperty("NightlyRate")]
        public List<NightlyRate> NightlyRate { get; set; }

        [JsonProperty("AverageNightlyRate")]
        public List<AverageNightlyRate> AverageNightlyRate { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }

        [JsonProperty("Commission")]
        public Commission Commission { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    [JsonObject("Product")]
    public class HotelAvailability_Product
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("propertyDatesRef")]
        public string PropertyDatesRef { get; set; }

        [JsonProperty("bookingCode")]
        public string BookingCode { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("RoomType")]
        public RoomType RoomType { get; set; }
    }

    [JsonObject("ProductOption")]
    public class HotelAvailability_ProductOption
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Product")]
        public List<Product> Product { get; set; }
    }

    [JsonObject("ProductRateCodeInfo")]
    public class HotelAvailability_ProductRateCodeInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("RateCodeInfo")]
        public RateCodeInfo RateCodeInfo { get; set; }
    }

    public class PropertyDate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("adaCompliant")]
        public string AdaCompliant { get; set; }

        [JsonProperty("PropertyKey")]
        public PropertyKey PropertyKey { get; set; }

        [JsonProperty("DateRange")]
        public DateRange DateRange { get; set; }
    }

    [JsonObject("PropertyKey")]
    public class HotelAvailability_PropertyKey
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }
    }

    [JsonObject("RateCodeInfo")]
    public class HotelAvailability_RateCodeInfo
    {
        [JsonProperty("rateCategory")]
        public string RateCategory { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rateID")]
        public string RateID { get; set; }
    }

    public class ReferenceList
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("PropertyDates")]
        public List<PropertyDate> PropertyDates { get; set; }
    }

    [JsonObject("RoomAmenity")]
    public class HotelAvailability_RoomAmenity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("includedInd")]
        public bool IncludedInd { get; set; }
    }

    [JsonObject("RoomCharacteristics")]
    public class HotelAvailability_RoomCharacteristics
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("viewCode")]
        public string ViewCode { get; set; }

        [JsonProperty("BedConfiguration")]
        public List<BedConfiguration> BedConfiguration { get; set; }

        [JsonProperty("smokingAllowed")]
        public string SmokingAllowed { get; set; }

        [JsonProperty("nonSmokingInd")]
        public bool? NonSmokingInd { get; set; }
    }

    [JsonObject("RoomType")]
    public class HotelAvailability_RoomType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("RoomCharacteristics")]
        public RoomCharacteristics RoomCharacteristics { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("RoomAmenity")]
        public List<RoomAmenity> RoomAmenity { get; set; }
    }

    public class Root
    {
        [JsonProperty("CatalogOfferingsHospitalityResponse")]
        public CatalogOfferingsHospitalityResponse CatalogOfferingsHospitalityResponse { get; set; }
    }

    [JsonObject("SpecificDate")]
    public class HotelAvailability_SpecificDate
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    [JsonObject("Tax")]
    public class HotelAvailability_Tax
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("includedInBase")]
        public string IncludedInBase { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    [JsonObject("Taxes")]
    public class HotelAvailability_Taxes
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("TotalTaxes")]
        public double TotalTaxes { get; set; }

        [JsonProperty("Tax")]
        public List<Tax> Tax { get; set; }

        [JsonProperty("TaxPercent")]
        public TaxPercent TaxPercent { get; set; }
    }

    public class TaxPercent
    {
        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }

        [JsonProperty("includedInBase")]
        public string IncludedInBase { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    [JsonObject("TermsAndConditions")]
    public class HotelAvailability_TermsAndConditions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Guarantee")]
        public List<Guarantee> Guarantee { get; set; }

        [JsonProperty("CancelPenalty")]
        public List<CancelPenalty> CancelPenalty { get; set; }

        [JsonProperty("AcceptedCreditCard")]
        public List<AcceptedCreditCard> AcceptedCreditCard { get; set; }

        [JsonProperty("Description")]
        public List<string> Description { get; set; }

        [JsonProperty("ProductRateCodeInfo")]
        public List<ProductRateCodeInfo> ProductRateCodeInfo { get; set; }

        [JsonProperty("RatePaymentInfo")]
        public string RatePaymentInfo { get; set; }
    }




}
