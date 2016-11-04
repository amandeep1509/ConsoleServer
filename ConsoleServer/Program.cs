using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerChannel serverchannel = new TcpServerChannel(13340);
            ChannelServices.RegisterChannel(serverchannel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ConsoleServer.RemCustomer), "RemCustomer", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Server is Running...");
            Console.WriteLine("Press Any key to halt the Server");
            Console.ReadKey();
        }
    }
}
