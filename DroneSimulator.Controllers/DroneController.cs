using DroneSimulator.Models;
using DroneSimulator.Services.interfaces;
using Utilities;

namespace DroneSimulator.Controllers
{
    public class DroneController : IDroneController
    {
        public Drone Start(Drone drone, Coordinates Boundry)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = Boundry;
            drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = 0 });
            drone.HornMode = (new Horn { Status = false, Time = 0 });
            drone.NavigationMode = string.Empty;
            return drone;
        }
        public Drone Start(Drone drone, Coordinates Boundry, Coordinates InitialPosition)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = Boundry;
            drone.InitialPosition = drone.CurrentPosition = InitialPosition;
            drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = 0 });
            drone.HornMode = (new Horn { Status = false, Time = 0 });
            drone.NavigationMode = string.Empty;
            return drone;
        }


        public Drone Restart(Drone drone)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = 0 });
            drone.HornMode = (new Horn { Status = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Shutdown(Drone drone)
        {
            drone.State = DroneStates.Shutdown;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = 0 });
            drone.HornMode = (new Horn { Status = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone InitialPosition(Drone drone, Coordinates InitialPosition)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = InitialPosition;// (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = 0 });
            drone.HornMode = (new Horn { Status = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Horn(Drone drone, int HornTime)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = 0 });
            drone.HornMode = (new Horn { Status = true, Time = HornTime });
            drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Light(Drone drone)
        {
            //drone.State = DroneStates.Start;
            //drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            //drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            //drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            //drone.FlashLightMode = (new Lights { Status = 0 });
            drone.LightMode = (new Lights { Status = (drone.LightMode == null) ? 0 : (drone.LightMode.Status == 0) ? 1 : 0 });
            //drone.HornMode = (new Horn { State = false, Time = 0 });
            //drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone FlashLight(Drone drone, int status)
        {
            //drone.State = DroneStates.Start;
            //drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            //drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            //drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = status });
            //drone.LightMode = (new Lights { Status = (status ? 0 : 1) });
            //drone.HornMode = (new Horn { State = true, Time = 0 });
            //drone.NavigationMode = string.Empty;

            return drone;
        }

        public Drone Move(Drone drone, int FlyingTime, CompassDirection.Direction direction)
        {
            int currentPosition = 0;
            Coordinates initialPoint = drone.CurrentPosition;

            switch (direction)
            {
                case CompassDirection.Direction.North:
                    currentPosition = initialPoint.yCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition + 1;
                        if(currentPosition >= drone.Boundary.yCoordinate)
                        {
                            drone.HornMode.State = DroneStates.BoundaryReached;
                            drone.HornMode.Time = 3;
                            break;
                        }
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = initialPoint.xCoordinate, yCoordinate = currentPosition };

                    break;
                case CompassDirection.Direction.South:
                    currentPosition = initialPoint.yCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition - 1;
                        if (currentPosition == 0)
                        {
                            drone.HornMode.Time = 3;
                            break;
                        }
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = initialPoint.xCoordinate, yCoordinate = currentPosition };

                    break;
                case CompassDirection.Direction.East:
                    currentPosition = initialPoint.xCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition + 1;
                        if (currentPosition >= drone.Boundary.xCoordinate)
                        {
                            drone.HornMode.Time = 3;
                            break;
                        }
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = currentPosition, yCoordinate = initialPoint.yCoordinate };

                    break;
                case CompassDirection.Direction.West:
                    currentPosition = initialPoint.xCoordinate;
                    for (int i = 0; i < FlyingTime; i++)
                    {
                        currentPosition = currentPosition - 1;
                        if (currentPosition == 0)
                        {
                            drone.HornMode.Time = 3;
                            break;
                        }
                    }
                    drone.CurrentPosition = new Coordinates { xCoordinate = currentPosition, yCoordinate = initialPoint.yCoordinate };

                    break;
            }
            return drone;
        }
    }
}
