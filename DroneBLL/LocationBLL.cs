using Drone.Models;
using System;

namespace DroneBLL
{
    public class LocationBLL
    {
        public Position _locCoordinate;
        public LocationBLL()
        {
            _locCoordinate.xcoordinate = 0;
            _locCoordinate.ycoordinate = 0;
        }
        public void ResetLocation()
        {
            _locCoordinate.xcoordinate = 0;
            _locCoordinate.ycoordinate = 0;
        }
        public Position GetLocation()
        {
            return _locCoordinate;
        }

        public void SetLocation(Position location)
        {
            if (location.xcoordinate > _locCoordinate.xcoordinate || location.ycoordinate > _locCoordinate.ycoordinate)
            {
                // TODO: Beep
                Console.WriteLine("Beep");
            }
        }
    }
}
