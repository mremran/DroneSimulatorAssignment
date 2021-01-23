using DroneSimulator.Controllers;
using DroneSimulator.Models;
using DroneSimulator.Services.interfaces;
using NUnit.Framework;

namespace DroneTest
{
    [TestFixture]
    public class DroneSimulatorTest
    {
        IDroneController droneController;
        [SetUp]
        public void Setup()
        {
            droneController = new DroneController();
        }

        [Test]
        public void StartDroneTest()
        {
            Drone drone = new Drone();
            Coordinates boundary = new Coordinates { xCoordinate = 25, yCoordinate = 35 };
            drone = droneController.Start(drone, boundary);

            Assert.AreEqual(drone.State, DroneStates.Start);
        }

        [Test]
        public void ShutdownDroneTest()
        {
            Drone drone = new Drone();
            drone = droneController.Shutdown(drone);
            Assert.AreEqual(drone.State, DroneStates.Shutdown);
        }

        [Test]
        public void TurnLightOnDroneTest()
        {
            Drone drone = new Drone();
            drone = droneController.Light(drone);
            Assert.AreEqual(drone.LightMode.Status, true);
        }

        [Test]
        public void TurnLightOffDroneTest()
        {
            Drone drone = new Drone();
            drone.LightMode = new Lights { Status = 1 };
            drone = droneController.Light(drone);
            Assert.AreEqual(drone.LightMode.Status, 0);
        }

        [Test]
        public void FlyNorthDroneTest()
        {
            Drone drone = new Drone();
            drone.CurrentPosition = new Coordinates { xCoordinate = 10, yCoordinate = 15 };
            drone = droneController.Move(drone, 10, CompassDirection.Direction.North);
            Assert.AreEqual(drone.CurrentPosition.yCoordinate, 25);
        }

        [Test]
        public void FlySouthDroneTest()
        {
            Drone drone = new Drone();
            drone.CurrentPosition = new Coordinates { xCoordinate = 10, yCoordinate = 10 };
            drone = droneController.Move(drone, 10, CompassDirection.Direction.South);
            Assert.AreEqual(drone.CurrentPosition.yCoordinate, 0);
        }

        [Test]
        public void FlyEastDroneTest()
        {
            Drone drone = new Drone();
            drone.CurrentPosition = new Coordinates { xCoordinate = 10, yCoordinate = 10 };
            drone = droneController.Move(drone, 10, CompassDirection.Direction.East);
            Assert.AreEqual(drone.CurrentPosition.yCoordinate, 20);
        }

        [Test]
        public void FlyWestDroneTest()
        {
            Drone drone = new Drone();
            drone.CurrentPosition = new Coordinates { xCoordinate = 10, yCoordinate = 10 };
            drone = droneController.Move(drone, 10, CompassDirection.Direction.West);
            Assert.AreEqual(drone.CurrentPosition.yCoordinate, 0);
        }

    }
}