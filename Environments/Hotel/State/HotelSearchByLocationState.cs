using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPortApi.Environments.Request;
using Newtonsoft.Json;

namespace TravelPortApi.Environments.State
{
    public class HotelSearchByLocationState
    {
      
        public string HotelSearchByLocationRequestState()
        {
            HotelSearchByLocationRequest hotelSearchByLocationRequest = new HotelSearchByLocationRequest();

            hotelSearchByLocationRequest.PropertiesQuerySearch = new PropertiesQuerySearch();
            hotelSearchByLocationRequest.PropertiesQuerySearch.CheckInDate = DateTime.Now.Date.ToString();
            hotelSearchByLocationRequest.PropertiesQuerySearch.CheckOutDate = DateTime.Now.AddDays(1).Date.ToString();
            hotelSearchByLocationRequest.PropertiesQuerySearch.ImageSize = "Large";
            hotelSearchByLocationRequest.PropertiesQuerySearch.RequestedCurrency = "EUR";
            //hotelSearchByLocationRequest.PropertiesQuerySearch.RoomStayCandidate = RoomStayCandidate;
            // RoomStayCandidate[0].GuestCounts.GuestCount[0].Count = 2;

            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy = new SearchBy();
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchRadius = new SearchRadius();
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchAddress = new SearchAddress();
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchRadius.Value = 5;
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchRadius.UnitOfDistance = "Miles";
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchAddress.City = "Denver";
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchAddress.StateProv = new Request.StateProv();
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchAddress.StateProv.Value = "CO";
            hotelSearchByLocationRequest.PropertiesQuerySearch.SearchBy.SearchAddress.Country = "US";

            return JsonConvert.SerializeObject(hotelSearchByLocationRequest);
        }
       
    }
}
