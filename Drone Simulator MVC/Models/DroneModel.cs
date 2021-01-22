using Microsoft.AspNetCore.Mvc;

namespace Drone_Simulator_MVC.Models
{
    [BindProperties]
    public class DroneModel
    {
        [BindProperty]
        public CoordinateModel InitialPosition { get; set; }
        [BindProperty]
        public CoordinateModel CurrentPosition { get; set; }
        [BindProperty]
        public CoordinateModel Boundary { get; set; }
        [BindProperty]
        public string NavigationMode { get; set; }
        [BindProperty]
        public string State { get; set; }
        [BindProperty]
        public LightModel LightMode { get; set; }
        [BindProperty]
        public LightModel FlashLightMode { get; set; }
        [BindProperty]
        public HornModel HornMode { get; set; }
    }
}
