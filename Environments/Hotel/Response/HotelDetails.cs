using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Response
{
    [JsonObject("AccessibilityFeature")]
    public class HotelDetail_AccessibilityFeature
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [JsonObject("Address")]
    public class HotelDetail_Address
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

    [JsonObject("Country")]
    public class HotelDetail_Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [JsonObject("GuestRoomInfo")]
    public class HotelDetail_GuestRoomInfo
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [JsonObject("Image")]
    public class HotelDetail_Image
    {
        [JsonProperty("dimensionCategory")]
        public string DimensionCategory { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("pictureCategory")]
        public int PictureCategory { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [JsonObject("Properties")]
    public class HotelDetail_Properties
    {
        [JsonProperty("PropertyInfo")]
        public List<PropertyInfo> PropertyInfo { get; set; }
    }

    [JsonObject("PropertiesResponse")]
    public class HotelDetail_PropertiesResponse
    {
        [JsonProperty("Properties")]
        public Properties Properties { get; set; }
    }

    [JsonObject("Property")]
    public class HotelDetail_Property
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("PropertyKey")]
        public PropertyKey PropertyKey { get; set; }

        [JsonProperty("Image")]
        public List<Image> Image { get; set; }

        [JsonProperty("Description")]
        public List<string> Description { get; set; }

        [JsonProperty("AccessibilityFeature")]
        public List<HotelDetail_AccessibilityFeature> AccessibilityFeature { get; set; }

        [JsonProperty("GuestRoomInfo")]
        public List<HotelDetail_GuestRoomInfo> GuestRoomInfo { get; set; }

        [JsonProperty("Address")]
        public Address Address { get; set; }

        [JsonProperty("Telephone")]
        public List<string> Telephone { get; set; }

        [JsonProperty("PropertyAmenity")]
        public List<HotelDetail_PropertyAmenity> PropertyAmenity { get; set; }
    }

    [JsonObject("PropertyAmenity")]
    public class HotelDetail_PropertyAmenity
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [JsonObject("PropertyInfo")]
    public class HotelDetail_PropertyInfo
    {
        [JsonProperty("Property")]
        public Property Property { get; set; }
    }

    [JsonObject("PropertyKey")]
    public class HotelDetail_PropertyKey
    {
        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }
    }

    public class HotelDetailsResponse
    {
        [JsonProperty("PropertiesResponse")]
        public PropertiesResponse PropertiesResponse { get; set; }
    }

    [JsonObject("StateProv")]
    public class HotelDetail_StateProv
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }


}
