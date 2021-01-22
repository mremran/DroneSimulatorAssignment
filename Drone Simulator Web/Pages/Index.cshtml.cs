using AutoMapper;
using Drone;
using Drone_Simulator_Web.Models;
using DroneBLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drone_Simulator_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string status { get; set; }
        //[BindProperty]
        public string ShowDronePanel = "none";

        [BindProperty]
        public PositionModel _positionModel { get; set; }// = new LocationModel();
        [BindProperty]
        public LocationModel _locationModel { get; set; }
        public iDrone _drone { get; set; }
        private IMapper _mapper;



        public IndexModel(ILogger<IndexModel> logger, iDrone drone, LocationModel locationModel, IMapper mapper)
        {
            _logger = logger;
            this._drone = drone;
            this._positionModel = new PositionModel();// locationModel;
            this._locationModel = locationModel;
            _mapper = mapper;
        }

        public void OnGet()
        {

        }

        public void OnPostStart(PositionModel positionModel)
        {
            if (ModelState.IsValid)
            {
                _locationModel = _mapper.Map<LocationModel>(positionModel);
                ShowDronePanel = "inline";
                status = "Starting the Done";
                _drone.SetPosition(_locationModel);
            }
        }
        public void OnPostFly(PositionModel positionModel)
        {
            _locationModel = _mapper.Map<LocationModel>(positionModel);
            ShowDronePanel = "inline";
            status = "Starting the Done";
            _drone.SetPosition(_locationModel);
        }
        public void OnPostReset(PositionModel positionModel)
        {
            _locationModel = _mapper.Map<LocationModel>(positionModel);
            ShowDronePanel = "inline";
            status = "Resetting the Done";
            _drone.SetPosition(_locationModel);
        }
        public void OnPostShutdown()
        {
            _locationModel = _mapper.Map<LocationModel>(_positionModel);
            ShowDronePanel = "none";
            status = "shutting the Done";
            _drone.SetPosition(_locationModel);
        }
    }
}
