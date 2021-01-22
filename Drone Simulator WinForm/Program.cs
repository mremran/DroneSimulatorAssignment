using System;
using System.Windows.Forms;
namespace Drone_Simulator_WinForm
{
    static class Program
    {
    private static IServiceProvider _serviceProvider;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Drone());
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<iDrone, APD001_XE02>();
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
