using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRovers
{
    class Program : IErrorChecking
    {
        static void Main(string[] args)
        {
            // Initialise variables 
            string[] boundary;
            string currentPosition;
            string instructions;
            List<Rover> rovers = new List<Rover>();

            // Get the maximum size of the plateau
            boundary = getBoundary();

            // Create plateau
            try
            {
                Plateau plateau = new Plateau(Int32.Parse(boundary[0]), Int32.Parse(boundary[1]));
            }
            catch (ArgumentNullException arg)
            {
                Console.WriteLine(arg.Message + " Hit any key to exit");
                Console.ReadLine();
                string ret = Console.ReadLine();
                if (ret == "y")
                    return;
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message + " Hit 'y' to exit");
                string ret = Console.ReadLine();
                if(ret == "y")
                    return;
            }          

            // Get current position and instructions for each rover 
            GetInput(out currentPosition, out instructions, rovers);
        }

        private static void GetInput(out string currentPosition, out string instructions, List<Rover> rovers)
        {
            currentPosition = null;
            instructions = null;

            // Get input from console
            // TODO error checking
            for (int i = 1; i < 3; i++)
            {

                // Get first rover's current position
                Console.WriteLine("Enter current position for rover {0} by using x <space> y <space> and orientation (N, E, W, S)", i);
                currentPosition = Console.ReadLine().ToUpper();

                // Get first rover's instructions for moving the rover
                Console.WriteLine("Enter instructions, in sequence, by using L, R or M");
                instructions = Console.ReadLine().ToUpper();

                // Create name rover objects, giving the number as they were created
                // i.e. MR1, MR2....
                Rover rover = new Rover();
                if (currentPosition.Length == 0)
                {
                    rover.SetRoverName("MR" + i.ToString());
                    rover.SetInitialPosition(currentPosition);
                    rover.GetInstructions(instructions);

                    // Add robot objects to list
                    rovers.Add(rover);
                }              
            }
        }

        private static string[] getBoundary()
        {
            string[] boundary;
            // Get plateau maximum size coordinates
            Console.WriteLine("Enter x and y coordinates of upper boundary in format x <space> y");
            boundary = Console.ReadLine().Split();
            return boundary;
        }
    }
}
