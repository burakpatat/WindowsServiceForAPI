using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Request
{
        public class GuestCount
        {
            [JsonProperty("count")]
            public int Count { get; set; }
        }

        public class GuestCounts
        {
            [JsonProperty("GuestCount")]
            public List<GuestCount> GuestCount { get; set; }
        }

        public class PropertiesQuerySearch
        {
            [JsonProperty("CheckInDate")]
            public string CheckInDate { get; set; }

            [JsonProperty("CheckOutDate")]
            public string CheckOutDate { get; set; }

            [JsonProperty("ImageSize")]
            public string ImageSize { get; set; }

            [JsonProperty("RequestedCurrency")]
            public string RequestedCurrency { get; set; }

            [JsonProperty("RoomStayCandidate")]
            public List<RoomStayCandidate> RoomStayCandidate { get; set; }

            [JsonProperty("SearchBy")]
            public SearchBy SearchBy { get; set; }
        }

        public class RoomStayCandidate
        {
            [JsonProperty("GuestCounts")]
            public GuestCounts GuestCounts { get; set; }
        }

        public class HotelSearchByLocationRequest
        {
            [JsonProperty("PropertiesQuerySearch")]
            public PropertiesQuerySearch PropertiesQuerySearch { get; set; }
        }

        public class SearchAddress
        {
            [JsonProperty("City")]
            public string City { get; set; }

            [JsonProperty("StateProv")]
            public StateProv StateProv { get; set; }

            [JsonProperty("Country")]
            public string Country { get; set; }
        }

        public class SearchBy
        {
            [JsonProperty("SearchRadius")]
            public SearchRadius SearchRadius { get; set; }

            [JsonProperty("SearchAddress")]
            public SearchAddress SearchAddress { get; set; }
        }

        public class SearchRadius
        {
            [JsonProperty("value")]
            public int Value { get; set; }

            [JsonProperty("unitOfDistance")]
            public string UnitOfDistance { get; set; }
        }

        public class StateProv
        {
            [JsonProperty("value")]
            public string Value { get; set; }
        }

}
