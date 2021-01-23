using System.ComponentModel.DataAnnotations;

namespace Drone_Simulator_MVC.Models
{
    public class CoordinateModel
    {
        [Required]
        [Display(Name = "X Coordinate")]
        [Range(0, 1500, ErrorMessage = "Only coordinates between 0 to 1500 are allowed")]
        public int xCoordinate { get; set; }


        [Required]
        [Display(Name = "Y Coordinate")]
        [Range(0, 1500, ErrorMessage ="Only coordinates between 0 to 1500 are allowed")]
        public int yCoordinate { get; set; }
    }
}
