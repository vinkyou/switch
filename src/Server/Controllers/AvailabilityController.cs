using Models.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;



namespace Server.Controllers
{
    public class AvailabilityController : ApiController
    {

        [HttpGet]
        public IEnumerable<LightAvailability> Get() {
            return Server.Nodes.Values;
        }

        [HttpPost]
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            var messageText = await request.Content.ReadAsStringAsync();
            try
            {
                var lightAvailability = JsonConvert.DeserializeObject<Models.Core.LightAvailability>(messageText);
                if (string.IsNullOrEmpty(lightAvailability.IpAddress)) return GetError("Invalid or null IP Address");
                if (lightAvailability.Port < 80 || lightAvailability.Port > 9090) return GetError("Invalid port");
                Console.WriteLine($"El nuevo bombillo esta en la Ip: {lightAvailability.IpAddress}");
                Console.WriteLine($"El nuevo bombillo esta en el puerto: {lightAvailability.Port}");
                Console.WriteLine($"El nuevo bombillo esta en nivel: {lightAvailability.Status}");
                Server.Nodes[$"{lightAvailability.IpAddress}:{lightAvailability.Port}"] = lightAvailability;
                Console.WriteLine($"Nodos activos en el servidor: {Server.Nodes.Count}");
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {                
                return GetError(ex.Message);
            }            
        }

        private HttpResponseMessage GetError(string message)
        {
            var response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            response.Content = new StringContent(message);
            return response;
        }

    }
}
