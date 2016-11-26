using System.Web.Http;
using System.Web.Http.SelfHost;

namespace LightBulbInstance
{
    public class InstanceListenerConfig
    {
        public const string ServerHostName = "localhost";

        public static HttpSelfHostConfiguration ConfigInstanceListener(int serverPort)
        {
            var config = new HttpSelfHostConfiguration($@"http://{ServerHostName}:{serverPort}");
            config.Routes.MapHttpRoute(
                    "API Default", "api/{controller}/");
            return config;
        }
    }
}