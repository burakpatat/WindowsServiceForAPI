using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Hotel.Response
{
    public class Amount
    {
        [JsonProperty("CurrencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("Base")]
        public int Base { get; set; }

        [JsonProperty("Taxes")]
        public Taxes Taxes { get; set; }

        [JsonProperty("Total")]
        public int Total { get; set; }

        [JsonProperty("TotalTaxes")]
        public int? TotalTaxes { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class AverageNightlyRate
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("approximateInd")]
        public bool ApproximateInd { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class BedConfiguration
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("bedType")]
        public string BedType { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public class CancelPenalty
    {
        [JsonProperty("Deadline")]
        public Deadline Deadline { get; set; }

        [JsonProperty("HotelPenalty")]
        public HotelPenalty HotelPenalty { get; set; }

        [JsonProperty("Refundable")]
        public string Refundable { get; set; }

        [JsonProperty("@type")]
        public string atType { get; set; }
    }

    public class CatalogOffering
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

    public class CatalogOfferings
    {
        [JsonProperty("CatalogOffering")]
        public List<CatalogOffering> CatalogOffering { get; set; }
    }

    public class CatalogOfferingsHospitalityResponse
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("CatalogOfferings")]
        public CatalogOfferings CatalogOfferings { get; set; }

        [JsonProperty("CurrencyRateConversion")]
        public List<CurrencyRateConversion> CurrencyRateConversion { get; set; }
    }

    public class Commission
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }

        [JsonProperty("Percent")]
        public int? Percent { get; set; }
    }

    public class ConversionRate
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class CurrencyCode
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CurrencyRateConversion
    {
        [JsonProperty("SourceCurrency")]
        public SourceCurrency SourceCurrency { get; set; }

        [JsonProperty("TargetCurrency")]
        public TargetCurrency TargetCurrency { get; set; }

        [JsonProperty("ConversionRate")]
        public ConversionRate ConversionRate { get; set; }
    }

    public class DateRange
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class Deadline
    {
        [JsonProperty("SpecificDate")]
        public SpecificDate SpecificDate { get; set; }

        [JsonProperty("Time")]
        public string Time { get; set; }

        [JsonProperty("@type")]
        public string atType { get; set; }
    }

    public class Description
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Guarantee
    {
        [JsonProperty("GuaranteeType")]
        public string GuaranteeType { get; set; }
    }

    public class HotelPenalty
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Amount")]
        public List<Amount> Amount { get; set; }

        [JsonProperty("@type")]
        public string atType { get; set; }

        [JsonProperty("Nights")]
        public int? Nights { get; set; }
    }

    public class Identifier
    {
        [JsonProperty("authority")]
        public string Authority { get; set; }
    }

    public class MealsIncluded
    {
        [JsonProperty("breakfastInd")]
        public bool BreakfastInd { get; set; }
    }

    public class NightlyRate
    {
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("nights")]
        public int Nights { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }
    }

    public class Price
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("CurrencyCode")]
        public CurrencyCode CurrencyCode { get; set; }

        [JsonProperty("Base")]
        public int Base { get; set; }

        [JsonProperty("TotalTaxes")]
        public double TotalTaxes { get; set; }

        [JsonProperty("TotalPrice")]
        public double TotalPrice { get; set; }

        [JsonProperty("PriceBreakdown")]
        public List<PriceBreakdown> PriceBreakdown { get; set; }
    }

    public class PriceBreakdown
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roomPricingType")]
        public string RoomPricingType { get; set; }

        [JsonProperty("Amount")]
        public Amount Amount { get; set; }

        [JsonProperty("Commission")]
        public Commission Commission { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("AverageNightlyRate")]
        public List<AverageNightlyRate> AverageNightlyRate { get; set; }

        [JsonProperty("priceChangesDuringStayInd")]
        public bool? PriceChangesDuringStayInd { get; set; }

        [JsonProperty("NightlyRate")]
        public List<NightlyRate> NightlyRate { get; set; }

        [JsonProperty("Base")]
        public int? Base { get; set; }

        [JsonProperty("TotalTaxes")]
        public double? TotalTaxes { get; set; }

        [JsonProperty("Total")]
        public double? Total { get; set; }
    }

    public class Product
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bookingCode")]
        public string BookingCode { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("PropertyKey")]
        public PropertyKey PropertyKey { get; set; }

        [JsonProperty("RoomType")]
        public RoomType RoomType { get; set; }

        [JsonProperty("DateRange")]
        public DateRange DateRange { get; set; }
    }

    public class ProductOption
    {
        [JsonProperty("Product")]
        public List<Product> Product { get; set; }
    }

    public class ProductRateCodeInfo
    {
        [JsonProperty("RateCodeInfo")]
        public RateCodeInfo RateCodeInfo { get; set; }
    }

    public class PropertyKey
    {
        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }
    }

    public class RateCodeInfo
    {
        [JsonProperty("rateID")]
        public string RateID { get; set; }
    }

    public class RoomAmenity
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("includedInd")]
        public bool IncludedInd { get; set; }
    }

    public class RoomCharacteristics
    {
        [JsonProperty("smokingAllowed")]
        public string SmokingAllowed { get; set; }

        [JsonProperty("wifiIncluded")]
        public string WifiIncluded { get; set; }

        [JsonProperty("BedConfiguration")]
        public List<BedConfiguration> BedConfiguration { get; set; }

        [JsonProperty("viewCode")]
        public string ViewCode { get; set; }
    }

    public class RoomOccupancy
    {
        [JsonProperty("maxOccupancy")]
        public int MaxOccupancy { get; set; }
    }

    public class RoomType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("RoomCharacteristics")]
        public RoomCharacteristics RoomCharacteristics { get; set; }

        [JsonProperty("Description")]
        public Description Description { get; set; }

        [JsonProperty("RoomAmenity")]
        public List<RoomAmenity> RoomAmenity { get; set; }

        [JsonProperty("RoomOccupancy")]
        public List<RoomOccupancy> RoomOccupancy { get; set; }
    }

    public class HotelAvailabilityResponse
    {
        [JsonProperty("CatalogOfferingsHospitalityResponse")]
        public CatalogOfferingsHospitalityResponse CatalogOfferingsHospitalityResponse { get; set; }
    }

    public class SourceCurrency
    {
        [JsonProperty("decimalPlace")]
        public int DecimalPlace { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SpecificDate
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class TargetCurrency
    {
        [JsonProperty("decimalPlace")]
        public int DecimalPlace { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Tax
    {
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }

        [JsonProperty("includedInBase")]
        public string IncludedInBase { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class Taxes
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Tax")]
        public List<Tax> Tax { get; set; }
    }

    public class TermsAndConditions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("Guarantee")]
        public List<Guarantee> Guarantee { get; set; }

        [JsonProperty("CancelPenalty")]
        public List<CancelPenalty> CancelPenalty { get; set; }

        [JsonProperty("RatePaymentInfo")]
        public string RatePaymentInfo { get; set; }

        [JsonProperty("Description")]
        public List<string> Description { get; set; }

        [JsonProperty("MealsIncluded")]
        public MealsIncluded MealsIncluded { get; set; }

        [JsonProperty("ProductRateCodeInfo")]
        public List<ProductRateCodeInfo> ProductRateCodeInfo { get; set; }
    }


}
