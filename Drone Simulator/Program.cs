using Microsoft.Extensions.DependencyInjection;
using System;

namespace Drone_Simulator
{
    class Program
    {
        private static IServiceProvider _serviceProvider;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var key = Console.ReadLine();

            switch (key.ToLower())
            {
                case "s":
                    Console.WriteLine("Started");
                    break;
                case "d":
                    Console.WriteLine("Shutdown");
                    break;
                default:
                    Console.WriteLine("Incorrect option");
                    break;
            }
            Console.ReadLine();
        }


        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            //services.AddScoped<iDrone, APD001_XE02>();
            //services.AddSingleton<ConsoleApplication>();
            _serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
