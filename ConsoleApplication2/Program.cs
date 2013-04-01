using System;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Hubs;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnection("http://localhost:53045/");

            try
            {
                connection.StateChanged += connection_StateChanged;

                var transport = new Microsoft.AspNet.SignalR.Client.Transports.LongPollingTransport();
                connection.Start(transport).Wait();
                Console.WriteLine("Connected");
                Console.ReadLine();
                //connection.Start().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine("SignalRConnection:StartConnection ex: " + ex.Message);
            }
        }

        static void connection_StateChanged(StateChange obj)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay.ToString() + "state changed from " + obj.OldState.ToString() + " to " + obj.NewState.ToString());
        }
    }
}
