using DroneSimulator.Models;
using DroneSimulator.Services.interfaces;

namespace DroneSimulator.Controllers
{
    public class DroneController : IDroneController
    {
        public Drone Start(Drone drone, Coordinates Boundry)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = Boundry;
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;
            return drone;
        }

        public Drone Restart(Drone drone)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Shutdown(Drone drone)
        {
            drone.State = DroneStates.Shutdown;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone InitialPosition(Drone drone, Coordinates InitialPosition)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = InitialPosition;// (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Horn(Drone drone, int HornTime)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = true, Time = HornTime });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Light(Drone drone)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = (drone.LightMode == null) ? true : !drone.LightMode.Status });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone FlashLight(Drone drone, bool status)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = status });
            drone.HornMode = (new Horn { State = true, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Move(Drone drone, int FlyingTime, CompassDirection.Direction direction)
        {
            int currentPosition = 0;
            switch (direction)
            {
                case CompassDirection.Direction.North:
                    currentPosition = drone.CurrentPosition.yCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition + 1;
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = drone.CurrentPosition.xCoordinate, yCoordinate = currentPosition };

                    break;
                case CompassDirection.Direction.South:
                    currentPosition = drone.CurrentPosition.yCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition - 1;
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = drone.CurrentPosition.xCoordinate, yCoordinate = currentPosition };

                    break;
                case CompassDirection.Direction.East:
                    currentPosition = drone.CurrentPosition.yCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition + 1;
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = drone.CurrentPosition.xCoordinate, yCoordinate = currentPosition };

                    break;
                case CompassDirection.Direction.West:
                    currentPosition = drone.CurrentPosition.yCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition - 1;
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = drone.CurrentPosition.xCoordinate, yCoordinate = currentPosition };

                    break;
            }
            return drone;
        }
    }
}
