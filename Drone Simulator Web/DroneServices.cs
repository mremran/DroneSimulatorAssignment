using Drone;
using DroneBLL.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Drone_Simulator_Web
{
    public static class DroneServices
    {
        public static IServiceCollection RegisterDroneServices(this IServiceCollection services)
        {
            return services
                    .AddTransient<LocationModel>(s => new LocationModel())
                    .AddTransient<iDrone, APD001_XE02>();
        }
    }
}
