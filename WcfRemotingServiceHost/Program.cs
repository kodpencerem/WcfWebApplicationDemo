using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace WcfRemotingServiceHost
{
    public class Program
    {
        static void Main()
        {
            GetMessageRemotingService.GetMessageRemotingService remotingService = new GetMessageRemotingService.GetMessageRemotingService();

            TcpChannel channel = new TcpChannel(8081);

            ChannelServices.RegisterChannel(channel);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(GetMessageRemotingService.GetMessageRemotingService), "GetMessage", WellKnownObjectMode.Singleton);

            Console.WriteLine("Remoting service started @ " + DateTime.Now);

            Console.ReadLine();

        }
    }
}