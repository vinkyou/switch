using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;

namespace LightBulbInstance.Controllers
{
    public class NodeController : ApiController
    {
        [HttpPut]
        public async Task<HttpResponseMessage> Put(HttpRequestMessage request)
        {
            var messageText = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
            try
            {
                var lightAvailability = JsonConvert.DeserializeObject<Models.Core.LightAvailability>(messageText);
                Program.InstanceValue = lightAvailability.Status;
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return GetError(ex.Message);
            }
        }

        private static HttpResponseMessage GetError(string message)
        {
            var response = new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent(message)
            };
            return response;
        }
    }
}