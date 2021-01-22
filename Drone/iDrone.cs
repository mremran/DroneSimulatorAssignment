using Drone.Models;

namespace Drone
{
    public interface iDrone
    {
        void SetPosition(Position position);
        //void Move(Position location, int Time);
        //void SetPosition(Position location, int droneState);
        //void SetPosition(Position location, int droneState, int flyTime);
    }
}
