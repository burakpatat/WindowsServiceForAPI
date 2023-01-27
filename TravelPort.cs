using Api.Enironments;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Timers;
using static System.Net.WebRequestMethods;
using TravelPortApi.Environments.Request;
using TravelPortApi.Environments.Response;
using TravelPortApi.Environments.State;

namespace TravelPortApi
{
    public partial class TravelPort : ServiceBase
    {
        IDbConnection connection;

        GetData GetService;
        public TravelPort()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            Timer timer = new Timer();
            timer.Interval = 60 * 1000; // 60 seconds 
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
            // GetUserTimelineTweets();
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {

        }
        protected override void OnStop()
        {
        }



        internal void TestStartupAndStop()
        {

            this.OnTimer(null, null);
            RunYourCode();
            this.OnStop();
        }
        public void RunYourCode()
        {
            GetService = new GetData();


            var RoomStayCandidate = new List<RoomStayCandidate>();


            HotelSearchByLocationState HotelSearchByLocation = new HotelSearchByLocationState();
            string _jsondata = HotelSearchByLocation.HotelSearchByLocationRequestState();

            var res = GetService.ResultResponse("/11/hotel/", Method.Post, " ", _jsondata);


            /*var hotelSearchResponse = JsonConvert.DeserializeObject<HotelSearchByLocationResponse>(res.Content);

            HotelsRepository repo = new HotelsRepository();
            var controlHotel = repo.GetByName("Name");
            if (controlHotel==null)
            {
                repo.Insert(new Model.Concrete.Hotels()
                {
                    Address = "Adres",
                    Name = "Name",
                    CityId= 1,
                    CommercialContactId= 1,
                    CountryId= 1,


                });
            }*/
           

        }

    }
}