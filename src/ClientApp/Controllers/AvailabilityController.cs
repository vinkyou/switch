using Models.Core;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ClientApp.Controllers
{
    public class AvailabilityController : Controller
    {
        public ActionResult CurrentActivenodes()
        {
            var client = new RestClient("http://localhost:8080/api/Availability/");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            var activeNodes = JsonConvert.DeserializeObject<IEnumerable<LightAvailability>>(response.Content);
            return View(activeNodes);
        }
    }
}