using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Drone State")]
        public string State { get; set; }

        [BindProperty]
        public LightModel LightMode { get; set; }

        [BindProperty]
        public LightModel FlashLightMode { get; set; }

        [BindProperty]
        public HornModel HornMode { get; set; }

        [Display(Name = "Flying Time")]
        [Range(1, int.MaxValue)]
        public int FlyTime { get; set; }

        [Required]
        [Display(Name = "Flying Direction")]
        public CompassDirection.Direction direction { get; set; }
    }
}
