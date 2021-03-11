using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = new Uri("http://localhost:5000/test");

            var clinicalEvicendeHub = new HubConnectionBuilder()
                .WithUrl(url)
                .AddNewtonsoftJsonProtocol()
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                    logging.SetMinimumLevel(LogLevel.Debug);
                })
                .Build();

            clinicalEvicendeHub.StartAsync().Wait();
            Console.WriteLine("Connected!");
            Console.ReadLine();
        }
    }
}
