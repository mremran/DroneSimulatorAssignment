using AutoMapper;
using Drone_Simulator_MVC.Models;
using DroneSimulator.Models;

namespace Drone_Simulator_Web
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<DroneModel, Drone>();
            CreateMap<Drone, DroneModel>();

            CreateMap<CoordinateModel, Coordinates>();
            CreateMap<Coordinates, CoordinateModel>();

            CreateMap<Horn, HornModel>();
            CreateMap<HornModel, Horn>();

            CreateMap<Lights, LightModel>();
            CreateMap<LightModel, Lights>();
        }
    }
}
