using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Response.HotelSearchByLocation
{ 
    public class Address
    {
        [JsonProperty("AddressLine")]
        public List<string> AddressLine { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("StateProv")]
        public StateProv StateProv { get; set; }

        [JsonProperty("Country")]
        public Country Country { get; set; }

        [JsonProperty("PostalCode")]
        public string PostalCode { get; set; }
    }

    public class ConversionRate
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Country
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

    public class Distance
    {
        [JsonProperty("unitOfDistance")]
        public string UnitOfDistance { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GeoLocation
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class Identifier
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }
    }

    public class Image
    {
        [JsonProperty("dimensionCategory")]
        public string DimensionCategory { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("pictureCategory")]
        public int PictureCategory { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class LowestAvailableRate
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Properties
    {
        [JsonProperty("totalProperties")]
        public int TotalProperties { get; set; }

        [JsonProperty("propertiesPerPage")]
        public int PropertiesPerPage { get; set; }

        [JsonProperty("Identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("PropertyInfo")]
        public List<PropertyInfo> PropertyInfo { get; set; }
    }

    public class PropertiesResponse
    {
        [JsonProperty("Properties")]
        public Properties Properties { get; set; }

        [JsonProperty("Result")]
        public Result Result { get; set; }

        [JsonProperty("CurrencyRateConversion")]
        public List<CurrencyRateConversion> CurrencyRateConversion { get; set; }
    }

    public class Property
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("PropertyKey")]
        public PropertyKey PropertyKey { get; set; }

        [JsonProperty("Rating")]
        public List<Rating> Rating { get; set; }

        [JsonProperty("GeoLocation")]
        public GeoLocation GeoLocation { get; set; }

        [JsonProperty("Address")]
        public Address Address { get; set; }

        [JsonProperty("Image")]
        public List<Image> Image { get; set; }
    }

    public class PropertyInfo
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("Distance")]
        public Distance Distance { get; set; }

        [JsonProperty("Property")]
        public Property Property { get; set; }

        [JsonProperty("Identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("LowestAvailableRate")]
        public LowestAvailableRate LowestAvailableRate { get; set; }
    }

    public class PropertyKey
    {
        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }
    }

    public class Rating
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Result
    {
        [JsonProperty("Warning")]
        public List<Warning> Warning { get; set; }
    }

    public class HotelSearchByLocationResponse
    {
        [JsonProperty("PropertiesResponse")]
        public PropertiesResponse PropertiesResponse { get; set; }
    }

    public class SourceCurrency
    {
        [JsonProperty("decimalPlace")]
        public int DecimalPlace { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class StateProv
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TargetCurrency
    {
        [JsonProperty("decimalPlace")]
        public int DecimalPlace { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Warning
    {
        [JsonProperty("StatusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }
}
