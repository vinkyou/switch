using System;
using System.Windows.Forms;

namespace LightBulbInstance
{
    public static class Program
    {
        private static readonly GuiConsoleWriter Console;

        public static double InstanceValue = 0;

        static Program()
        {
            Console = new GuiConsoleWriter();
        }

        private static void ThrowException(string message)
        {
            Console.ChangeColor(ConsoleColor.Red);
            Console.WriteLine(message);
            Console.ChangeColor(ConsoleColor.White);
            Environment.Exit(0);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {

            //if (args.Length < 1) ThrowException("No se ha especificado la ubicación del bombillo");

            //if (args.Length < 2) ThrowException("No se ha especificado el puerto asociado al bombillo");

            //var place = args[0];

            //int port;

            //var isValidPort = int.TryParse(args[1], out port) && port > 0 && port < 999;

            //if (!isValidPort) ThrowException("El puerto especificado no es válido");

            string place = "Test";
            int port = 82;

            try
            {
                InstanceListener.StartInstance(place, port);
            }
            catch (Exception e)
            {
                ThrowException(e.Message);
            }
            
        }
    }
}