using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Rover : IGetInitialPosition
    {
        public string name;
        public string number;
        public string initialPosition;
        public enum orientation { N, E, W, S}


        public Rover(string r_name, string r_number)
        {
            name = r_name;
            number = r_number;
        }

        public void GetInitialPosition(string input)
        {
            initialPosition = input;
        }
    }
}
