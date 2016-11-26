using System.Web.Http;
using System.Web.Http.SelfHost;

namespace Server.App_Start
{
    internal class ServerConfig
    {
        public const long ServerPort = 8080;
        public const string ServerHostName = "localhost";

        public static HttpSelfHostConfiguration ConfigServer()
        {
            var config = new HttpSelfHostConfiguration(
                $@"http://{ServerHostName}:{ServerPort}");
            config.Routes.MapHttpRoute(
                    "API Default", "api/{controller}/");
            return config;
        }
    }
}