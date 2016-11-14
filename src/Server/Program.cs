using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.ConsoleUtils;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server.StartServer();
            ConsoleMessages.WriteLine("Goodbye!!!!", MessageType.Info);            
        }
    }
}
