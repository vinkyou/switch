using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Core;

namespace ClientApp.Controllers
{
    public class AvailabilityController:Controller
    {

        public ActionResult CurrentActivenodes() {

            var client = new RestClient("http://localhost:8080/api/Availability/");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var activeNodes = JsonConvert.DeserializeObject<IEnumerable<LightAvailability>>(response.Content);
            return View(activeNodes);
        }




    }
}