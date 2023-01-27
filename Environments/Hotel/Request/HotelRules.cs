using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.Hotel.Request
{
    public class OfferQueryHospitalityRequest
    {
        [JsonProperty("bookingCode")]
        public string BookingCode { get; set; }

        [JsonProperty("requestedCurrency")]
        public string RequestedCurrency { get; set; }

        [JsonProperty("checkinDate")]
        public string CheckinDate { get; set; }

        [JsonProperty("checkoutDate")]
        public string CheckoutDate { get; set; }

        [JsonProperty("numberOfGuests")]
        public int NumberOfGuests { get; set; }

        [JsonProperty("storedAmount")]
        public string StoredAmount { get; set; }

        [JsonProperty("storedCurrency")]
        public string StoredCurrency { get; set; }

        [JsonProperty("HotelAggregator")]
        public string HotelAggregator { get; set; }

        [JsonProperty("PropertyKey")]
        public PropertyKey PropertyKey { get; set; }
    }

    [JsonObject("PropertyKey")]
    public class HotelRulesPropertyKey
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }
    }

    public class RateCandidate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rateCode")]
        public string RateCode { get; set; }

        [JsonProperty("chainCode")]
        public string ChainCode { get; set; }

        [JsonProperty("propertyCode")]
        public string PropertyCode { get; set; }

        [JsonProperty("rateID")]
        public string RateID { get; set; }
    }

    public class HotelRulesRequest
    {
        [JsonProperty("OfferQueryHospitalityRequest")]
        public OfferQueryHospitalityRequest OfferQueryHospitalityRequest { get; set; }

        [JsonProperty("RateCandidate")]
        public List<RateCandidate> RateCandidate { get; set; }
    }

}
