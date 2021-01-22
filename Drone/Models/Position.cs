using System.ComponentModel.DataAnnotations;

namespace Drone.Models
{
    public class Position
    {
        public Position()
        {
            xcoordinate = ycoordinate = xBorder = yBorder = 0;
        }
        [Required]
        [Range(0, 100)]
        public int xcoordinate { get; set; }
        [Required]
        [Range(0, 100)]
        public int ycoordinate { get; set; }

        [Required]
        [Range(1, 100)]
        public int xBorder { get; set; }
        [Required]
        [Range(1, 100)]
        public int yBorder { get; set; }
    }
}
