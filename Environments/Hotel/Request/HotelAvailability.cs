using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Hotel.Request
{
    public class CatalogOfferingsQueryRequest
    {
        [JsonProperty("CatalogOfferingsRequest")]
        public List<CatalogOfferingsRequest> CatalogOfferingsRequest { get; set; }
    }

    public class CatalogOfferingsRequest
    {
        [JsonProperty("verboseResponseInd")]
        public bool VerboseResponseInd { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("StayDates")]
        public StayDates StayDates { get; set; }

        [JsonProperty("HotelSearchCriterion")]
        public HotelSearchCriterion HotelSearchCriterion { get; set; }
    }

    public class GuestCount
    {
        [JsonProperty("ageQualifyingCode")]
        public string AgeQualifyingCode { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }
    }

    public class GuestCounts
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("GuestCount")]
        public List<GuestCount> GuestCount { get; set; }
    }

    public class HotelSearchCriterion
    {
        [JsonProperty("numberOfRooms")]
        public int NumberOfRooms { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("PropertyRequest")]
        public List<PropertyRequest> PropertyRequest { get; set; }

        [JsonProperty("RoomStayCandidates")]
        public RoomStayCandidates RoomStayCandidates { get; set; }
    }

    public class PropertyKey
    {
        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }

        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
    }

    public class PropertyRequest
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("PropertyKey")]
        public PropertyKey PropertyKey { get; set; }
    }

    public class RoomStayCandidate
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("GuestCounts")]
        public GuestCounts GuestCounts { get; set; }
    }

    public class RoomStayCandidates
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("RoomStayCandidate")]
        public List<RoomStayCandidate> RoomStayCandidate { get; set; }
    }

    public class HotelAvailabilityRequest
    {
        [JsonProperty("CatalogOfferingsQueryRequest")]
        public CatalogOfferingsQueryRequest CatalogOfferingsQueryRequest { get; set; }
    }

    public class StayDates
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }


}
