using DroneSimulator.Models;

namespace DroneSimulator.Services.interfaces
{
    public interface IDroneController
    {
        public Drone Start(Drone drone, Coordinates Boundry);
        public Drone InitialPosition(Drone drone, Coordinates InitialPosition);
        public Drone Shutdown(Drone drone);
        public Drone Restart(Drone drone);
        public Drone Horn(Drone drone, int HornTime);
        public Drone Light(Drone drone);
        public Drone FlashLight(Drone drone, bool status);
        public Drone Move(Drone drone, int FlyingTime, CompassDirection.Direction direction);
    }
}
