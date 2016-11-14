using Server.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.SelfHost;
using Server.ConsoleUtils;

namespace Server
{
    internal static class Server
    {

        private static readonly IDictionary<string, Models.Core.LightAvailability> _nodes;

        static Server() {
            _nodes = new Dictionary<string, Models.Core.LightAvailability>();
        }

        public static IDictionary<string, Models.Core.LightAvailability> Nodes => _nodes;

        public static void StartServer()
        {

            var config = ServerConfig.ConfigServer();


            using (var server = new HttpSelfHostServer(config))
            {
                bool serverIsUp = false;
                try
                {
                    server.OpenAsync().Wait();
                    serverIsUp = true;
                }
                catch (AggregateException ae)
                {
                    var baseException = ae.GetBaseException();

                    if (baseException != null && baseException is System.ServiceModel.AddressAccessDeniedException)
                    {
                        ConsoleMessages.WriteException("Sorry, there are no permissions to register the port for the server (Default 8080). Please try to open the server with administrative permissions.", true);
                    }
                    else if (baseException != null && baseException is System.ServiceModel.AddressAlreadyInUseException)
                    {
                        ConsoleMessages.WriteException("Sorry, the default port (8080) for the server is already in using by another application. Please check that only has one instance of the server running.", true);
                    }
                }
                catch (System.Exception)
                {
                    ConsoleMessages.WriteException("Sorry, we have encountered an unexpected error when trying to start the server. Please try again.", true);
                }
                if (serverIsUp)
                {
                    HandleStopServer(true);
                    server.CloseAsync().Wait();
                }
            }
        }


        private static void HandleStopServer(bool ClearConsole = false)
        {
            if (ClearConsole)
                Console.Clear();
            Console.WriteLine("The server is running. Processing requests...", MessageType.Info);
            Console.WriteLine("Press 'P' key to stop the server. Note that this action will cancel any requests from any client.", MessageType.Warning);
            System.ConsoleKeyInfo ki = System.Console.ReadKey(true);
            if (ki.Key == System.ConsoleKey.P)
            {
                Console.WriteLine("Are you sure to stop the server? This will cancel any clients request in progress.", MessageType.Error);
                Console.Write("Press 'Y' to stop the server: ", MessageType.Warning);
                System.ConsoleKeyInfo kiS = System.Console.ReadKey();
                if (kiS.Key == System.ConsoleKey.Y)
                {
                    Console.WriteLine();
                    Console.WriteLine("Stopping the server. Please wait.", MessageType.Info);
                    return;
                }
                else
                {
                    HandleStopServer(true);
                }
            }
            else
            {
                HandleStopServer(true);
            }
        }
    }
}
