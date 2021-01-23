using DroneSimulator.Models;

namespace DroneSimulator.Services.interfaces
{
    public interface IDroneController
    {
        /// <summary>
        /// This method will start the drone.
        /// </summary>
        /// <param name="drone">Drone object</param>
        /// <param name="Boundry">Boundary coordinates</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Start(Drone drone, Coordinates Boundry);
        /// <summary>
        /// This module will start the drone with boundary and initial position.
        /// </summary>
        /// <param name="drone">Drone object</param>
        /// <param name="Boundry">Boundary coordinates</param>
        /// <param name="InitialPosition">Initial position coordinates</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Start(Drone drone, Coordinates Boundry, Coordinates InitialPosition);
        /// <summary>
        /// This will set the Initial Position of the dorne.
        /// </summary>
        /// <param name="drone">Done object</param>
        /// <param name="InitialPosition">Initial position coordinates</param>
        /// <returns>Drone object with properties set</returns>
        public Drone InitialPosition(Drone drone, Coordinates InitialPosition);

        /// <summary>
        /// This method will shut down the drone.
        /// </summary>
        /// <param name="drone">Drone object</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Shutdown(Drone drone);
        /// <summary>
        /// This method will reset the the drone to the initial start state.
        /// </summary>
        /// <param name="drone">Drone object.</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Restart(Drone drone);

        /// <summary>
        /// This method will set the drone's horn state.
        /// </summary>
        /// <param name="drone">Drone object</param>
        /// <param name="HornTime">For how long the horn will be blown.</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Horn(Drone drone, int HornTime);
        /// <summary>
        /// This method will set the drone's light (toggle)
        /// </summary>
        /// <param name="drone">Drone object</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Light(Drone drone);
        /// <summary>
        /// This method will set the drone's flasher status
        /// </summary>
        /// <param name="drone">Drone object</param>
        /// <param name="status">Flasher's status</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone FlashLight(Drone drone, int status);
        /// <summary>
        /// This will move the drone in Rail mode
        /// </summary>
        /// <param name="drone">Rone Object</param>
        /// <param name="FlyingTime">For how long will the drone fly.</param>
        /// <param name="direction">Compass direction of the flight</param>
        /// <returns>Drones object with the properties set</returns>
        public Drone Move(Drone drone, int FlyingTime, CompassDirection.Direction direction);
    }
}
