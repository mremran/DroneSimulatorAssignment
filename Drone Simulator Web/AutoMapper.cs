using AutoMapper;
using Drone_Simulator_Web.Models;
using DroneBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drone_Simulator_Web
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<PositionModel, LocationModel>();
            CreateMap<LocationModel,PositionModel >();
        }
    }
}
