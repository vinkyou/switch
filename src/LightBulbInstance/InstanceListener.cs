using Models.Core;
using RestSharp;
using System;
using System.Web.Http.SelfHost;
using System.Windows.Forms;

namespace LightBulbInstance
{
    internal static class InstanceListener
    {
        public static void NotifyStartUpToServer(string place, int port)
        {
            var client = new RestClient("http://localhost:8080/api/Availability/");                                         
            var request = new RestRequest(Method.POST);
            request.AddBody(new LightAvailability
            {
                Name = place,
                Port = port,
                Status = 0
            });
            client.Execute(request);
        }

        public static void StartInstance(string place, int port)
        {
            var config = InstanceListenerConfig.ConfigInstanceListener(port);

            using (var instance = new HttpSelfHostServer(config))
            {
                var instanceIsUp = false;
                try
                {
                    instance.OpenAsync().Wait();
                    instanceIsUp = true;
                    NotifyStartUpToServer(place, port);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1(place, port));
                }
                catch (AggregateException ae)
                {
                    var baseException = ae.GetBaseException();

                    if (baseException is System.ServiceModel.AddressAccessDeniedException)
                    {
                        throw new Exception("Sorry, there are no permissions to register the port for the InstanceListener (Default 8080). Please try to open the InstanceListener with administrative permissions.");
                    }
                    else if (baseException is System.ServiceModel.AddressAlreadyInUseException)
                    {
                        throw new Exception("Sorry, the default port (8080) for the InstanceListener is already in using by another application. Please check that only has one instance of the InstanceListener running.");
                    }
                }
                catch (System.Exception)
                {
                    throw new Exception("Sorry, we have encountered an unexpected error when trying to start the InstanceListener. Please try again.");
                }
                if (!instanceIsUp) return;
                
                HandleStopInstanceListener();
                instance.CloseAsync().Wait();
            }
        }

        private static void HandleStopInstanceListener()
        {
        }
    }
}