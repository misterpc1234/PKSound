using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Rover : IGetInitialPosition, ISetRoverName, IGetInstructions
    {
        public string name;
        public string initialPosition;
        public string instructions;

        public enum orientation { N, E, W, S}

        public void SetRoverName(string roverName)
        {
            name = roverName;
        }

        public void GetInitialPosition(string input)
        {
            initialPosition = input;
        }

        public void GetInstructions(string receivedInstuctions)
        {
            instructions = receivedInstuctions;
        }
    }
}
