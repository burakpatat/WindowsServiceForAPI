using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Response.HotelDetail
{
    public class AccessibilityFeature
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

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

    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GuestRoomInfo
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Image
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

    public class Properties
    {
        [JsonProperty("PropertyInfo")]
        public List<PropertyInfo> PropertyInfo { get; set; }
    }

    public class PropertiesResponse
    {
        [JsonProperty("Properties")]
        public Properties Properties { get; set; }
    }

    public class Property
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
        public List<AccessibilityFeature> AccessibilityFeature { get; set; }

        [JsonProperty("GuestRoomInfo")]
        public List<GuestRoomInfo> GuestRoomInfo { get; set; }

        [JsonProperty("Address")]
        public Address Address { get; set; }

        [JsonProperty("Telephone")]
        public List<string> Telephone { get; set; }

        [JsonProperty("PropertyAmenity")]
        public List<PropertyAmenity> PropertyAmenity { get; set; }
    }

    public class PropertyAmenity
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class PropertyInfo
    {
        [JsonProperty("Property")]
        public Property Property { get; set; }
    }

    public class PropertyKey
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

    public class StateProv
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }


}
