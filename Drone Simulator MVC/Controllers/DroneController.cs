using Drone_Simulator_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Drone_Simulator_MVC.Controllers
{
    public class DroneController : Controller
    {
        private readonly ILogger<DroneController> _logger;
        //public iDrone _drone;
        //public SimulatorModel _simulator;

        //public DroneController(ILogger<DroneController> logger, iDrone drone)
        //{
        //    _logger = logger;
        //    _drone = drone;
        //    _simulator = new SimulatorModel(drone);
        //}


        //// GET: DroneController
        //public ActionResult Index()
        //{
        //    return View(_simulator);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Start(SimulatorModel model)
        //{
        //    //model.DroneState.state = DroneStates.Start;
        //    return View("Index", model);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Shutdown(SimulatorModel model)
        //{
        //    //model.DroneState.state = DroneStates.Shutdown;
        //    model.DronePosition.xBorder = model.DronePosition.yBorder = 0;
        //    return View("Index", model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Light(SimulatorModel model)
        //{
        //    //model.DroneState.state = DroneStates.Start;
        //    model.Dronelight.status = (model.Dronelight.status == LightEnum.On) ? LightEnum.Off : LightEnum.On;
        //    return View("Index", model);
        //}
    }
}
