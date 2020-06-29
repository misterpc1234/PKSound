using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    public class Rover : ISetInitialPosition, ISetRoverName, IGetInstructions, IRotateRight, IRotateLeft, IAdvance
    {
        public string name;
        public string position;
        public string instructions;

        public void SetRoverName(string roverName)
        {
            name = roverName;
        }

        public void SetInitialPosition(string input)
        {
            position = input;
        }

        public void GetInstructions(string receivedInstuctions)
        {
            instructions = receivedInstuctions;
        }

        public string rotateRight(string right)
        {
            string tmp = position;
            
            if (right == "N")
                position = tmp.Replace('N','E'); 
            else if (right == "E")
                position = tmp.Replace('E', 'S');
            else if (right == "S")
                position = tmp.Replace('S','W');
            else if (right == "W")
                    position = tmp.Replace('W','N');

            return position;

        }

        public string rotateLeft(string left)
        {
            string tmp = position;

            if (left == "N")
                position = tmp.Replace('N', 'W');
            else if (left == "W")
                position = tmp.Replace('W', 'S');
            else if (left == "S")
                position = tmp.Replace('S', 'E');
            else if (left == "E")
                position = tmp.Replace('E', 'N');

            return position;
        }

        // If the rover is facing north and advance is called increment the x coodinate
        // If the rover is facing south and advance is called decrement the x coodinate
        public string AdvanceX()
        {
            int x;
            List<string> pos = position.Split(' ').ToList();
            string tmp;

            if ( (tmp = pos.ElementAt(2)) == "N")
            {
                x = Int32.Parse(pos[0]);
                x++;
                pos[0] = x.ToString();
            }
            if ((tmp = pos.ElementAt(2)) == "S")
            {
                x = Int32.Parse(pos[0]);
                x--;
                pos[0] = x.ToString();
            }

            // Add white spaces
            for (int i = 1; i < pos.Count; i +=2)
                pos.Insert(i," ");

            // Copy new rover position to new coordinates
            position = String.Concat(pos);

            return position;
        }

        public string AdvanceY()
        {
            int y;
            List<string> pos = position.Split(' ').ToList();
            string tmp;

            if ((tmp = pos.ElementAt(2)) == "E")
            {
                y = Int32.Parse(pos[1]);
                y++;
                pos[1] = y.ToString();
            }
            if ((tmp = pos.ElementAt(2)) == "W")
            {
                y = Int32.Parse(pos[1]);
                y--;
                pos[1] = y.ToString();
            }

            // Add white spaces
            for (int i = 1; i < pos.Count; i += 2)
                pos.Insert(i, " ");

            // Copy new rover position to new coordinates
            position = String.Concat(pos);

            return position;
        }
    }
}
