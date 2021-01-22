using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Drone.Models
{
    public class Horn
    {
        [Required]
        public int status { get; set; }
        [Required]
        public int time { get; set; }
    }
}
