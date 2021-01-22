using System;
using System.Collections.Generic;
using System.Text;

namespace DroneSimulator.Models
{
    public class Drone
    {
        public Coordinates InitialPosition { get; set; }
        public Coordinates CurrentPosition { get; set; }
        public Coordinates Boundary { get; set; }
        public string NavigationMode { get; set; }
        public string State { get; set; }
        public Lights LightMode { get; set; }
        public Lights FlashLightMode { get; set; }
        public Horn HornMode { get; set; }
        //public string ActionType { get; set; }

        // Move(drone, time, nav mode, direction)

    }
}
