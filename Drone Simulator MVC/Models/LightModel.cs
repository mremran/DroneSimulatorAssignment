using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Drone_Simulator_MVC.Models
{
    [BindProperties]
    public class LightModel
    {
        [BindProperty]
        [Required]
        public int Status { get; set; } // On, Off
    }
}
