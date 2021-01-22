using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Drone.Models
{
    public class State
    {
        [Required]
        public int state { get; set; }
    }
}
