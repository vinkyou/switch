using Server.ConsoleUtils;

namespace Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Server.StartServer();
            ConsoleMessages.WriteLine("Goodbye!!!!", MessageType.Info);
        }
    }
}