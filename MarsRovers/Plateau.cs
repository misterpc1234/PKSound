using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    // Once the grid coordinates are set, it should remain constant
    // so that an illegal move by a Rover can be detected 
    
    public sealed class Plateau
    {
        // The grid coordinates are taken from the first line
        // of the input received.  The lower right and left
        // are, according to the spec, to be x = y = 0
        public int upper_x { get; set; }
        public int upper_y { get; set; }
        public const int lower_x = 0;
        public const int lower_y = 0;

        public Plateau(int top_x, int top_y)
        {
            upper_x = top_x;
            upper_y = top_y;
        }
    }
    
}
