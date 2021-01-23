using System;
using System.ComponentModel.DataAnnotations;

namespace Drone_Simulator_MVC.Models
{
    public class HornModel
    {
        public string State { get; set; }
        [Range(1,15)]
        public int Time { get; set; }
        public bool Status { get; set; }
    }
}
