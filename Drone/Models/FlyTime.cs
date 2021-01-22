using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Drone.Models
{
    public class FlyTime
    {
        [Required]
        public int flytime { get; set; }
    }
}
