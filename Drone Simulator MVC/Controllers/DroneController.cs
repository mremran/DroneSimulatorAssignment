using AutoMapper;
using Drone_Simulator_MVC.Models;
using DroneSimulator.Models;
using DroneSimulator.Services.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Drone_Simulator_MVC.Controllers
{
    public class DroneController : Controller
    {
        private readonly ILogger<DroneController> _logger;
        public IDroneController _simulator;
        private IMapper _mapper;

        public DroneController(ILogger<DroneController> logger, IDroneController drone, IMapper  mapper)
        {
            _logger = logger;
            _simulator = drone;
            _mapper = mapper;
        }


        public ActionResult Index()
        {
            DroneModel drone = new DroneModel();
            drone.InitialPosition = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            drone.Boundary = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            drone.CurrentPosition = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            drone.FlashLightMode = new LightModel { Status = 0 };
            drone.LightMode = new LightModel { Status = 0 };
            drone.HornMode = new HornModel { Status = false, Time = 0 };
            drone.State = DroneStates.Shutdown;
            drone.NavigationMode = "";
            drone.FlyTime = 1;
            return View(drone);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Start(DroneModel model)
        {
            if(model.InitialPosition.xCoordinate>model.Boundary.xCoordinate
                || model.InitialPosition.yCoordinate>model.Boundary.yCoordinate)
            {
                ModelState.AddModelError("InitialPosition.xCoordinate", "Initial position cannot be more than the boundary.");
                return View("Index", model);
            }
            Coordinates coordinate = _mapper.Map<Coordinates>(model.Boundary);
            Coordinates initialPosition = _mapper.Map<Coordinates>(model.InitialPosition);
            model.State = DroneStates.Start;
            Drone drone = _mapper.Map<Drone>(model);
            drone = _simulator.Start(drone, coordinate, initialPosition);
            model = _mapper.Map<DroneModel>(drone);
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Shutdown(DroneModel model)
        {
            model = new DroneModel();
            model.InitialPosition = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            model.Boundary = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            model.CurrentPosition = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            model.FlashLightMode = new LightModel { Status = 0 };
            model.LightMode = new LightModel { Status = 0 };
            model.HornMode = new HornModel { Status = false, Time = 0 };
            model.State = DroneStates.Shutdown;
            model.NavigationMode = "";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Restart(DroneModel model)
        {
            model = new DroneModel();
            model.InitialPosition = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            model.Boundary = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            model.CurrentPosition = new CoordinateModel { xCoordinate = 0, yCoordinate = 0 };
            model.FlashLightMode = new LightModel { Status = 0 };
            model.LightMode = new LightModel { Status = 0 };
            model.HornMode = new HornModel { Status = false, Time = 0 };
            model.State = DroneStates.Restart;
            model.NavigationMode = "";
            model.FlyTime = 1;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Light(DroneModel model)
        {
            Drone drone = _mapper.Map<Drone>(model);
            drone = _simulator.Light(drone);
            model = _mapper.Map<DroneModel>(drone);
            return View("Index", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Horn(DroneModel model)
        {
            Drone drone = _mapper.Map<Drone>(model);
            drone = _simulator.Horn(drone, model.HornMode.Time);
            model = _mapper.Map<DroneModel>(drone);
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Move(DroneModel model)
        {
            Drone drone = _mapper.Map<Drone>(model);           
            drone = _simulator.Move(drone, model.FlyTime, model.direction);
            model = _mapper.Map<DroneModel>(drone);
            if (model.HornMode.State == DroneStates.BoundaryReached)
            {
                ModelState.AddModelError("FlyTime", DroneStates.BoundaryReached);
            }
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Flash(DroneModel model)
        {
            Drone drone = _mapper.Map<Drone>(model);
            drone = _simulator.FlashLight(drone, ((model.FlashLightMode.Status ==0)? 1: 0));
            model = _mapper.Map<DroneModel>(drone);
            return View("Index", model);
        }
    }
}
