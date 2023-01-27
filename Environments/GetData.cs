using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Configuration;

namespace Api.Enironments
{
    public class GetData
    {
        public static string _GETResponseResult = "";
        public static string _POSTResponseResult = "";

        protected static string Get_SubUrl(GetTarget target, string[] args, string subUrl)
        {

            string extension = "";
            switch (target)
            {
                case GetTarget.BASE:
                    extension += subUrl;
                    break;
                case GetTarget.FILE:
                    extension += "/assets/";
                    break;
                default:
                    break;

            }

            return extension;
        }
        protected static string Post_SubUrl(PostTarget target, string[] args, string subUrl)
        {

            string extension = "";
            switch (target)
            {
                case PostTarget.NEWBASE:
                    extension += subUrl;
                    break;

                default:
                    break;

            }

            return extension;
        }
        protected static string Update_SubUrl(UpdateTarget target, string subUrl)
        {

            string extension = "";
            switch (target)
            {
                case UpdateTarget.UPDATEBASE:
                    extension += subUrl;
                    break;

                default:
                    break;

            }

            return extension;
        }
        protected static string Delete_SubUrl(DeleteTarget target, string subUrl)
        {

            string extension = "";
            switch (target)
            {
                case DeleteTarget.DELETEBASE:
                    extension += subUrl;
                    break;

                default:
                    break;

            }

            return extension;
        }
        public RestResponse ResultResponse(string subURL, Method method, string token,string jsonData)
        {
            if (ConfigurationManager.AppSettings["IsProd"].ToBool()) 
                subURL =  ConfigurationManager.AppSettings["TravelPortProd"].ToString()+ subURL; 
            else  
                subURL =  ConfigurationManager.AppSettings["TravelPortTest"].ToString()+ subURL;  
            var client = new RestClient(subURL);
            RestRequest request = new RestRequest(subURL, method);
            request.AddHeader("Authorization", "Bearer " + token);
            request.Timeout = 10; 
            request.AddStringBody(jsonData, DataFormat.Json);
            RestResponse response = client.ExecutePost(request);
            return response;
        }
        public RestResponse TokenResultResponse(string subURL, Method method, string token, string jsonData)
        {
            if (ConfigurationManager.AppSettings["IsProd"].ToBool())
                subURL = ConfigurationManager.AppSettings["TravelPortProdToken"].ToString() + subURL;
            else
                subURL = ConfigurationManager.AppSettings["TravelPortTestToken"].ToString() + subURL;
            var client = new RestClient(subURL);
            RestRequest request = new RestRequest(subURL, method);
            request.AddHeader("Authorization", "Bearer " + token);
            request.Timeout = 10;
            request.AddStringBody(jsonData, DataFormat.Json);
            RestResponse response = client.ExecutePost(request);
            return response;
        }
    }
    public enum GetTarget { BASE, FILE }
    public enum PostTarget { NEWBASE }
    public enum UpdateTarget { UPDATEBASE }
    public enum DeleteTarget { DELETEBASE }
}
