using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRovers;

namespace UnitTests
{
    [TestClass]
    public class MarsRoversTests
    {
        [TestMethod]
        public void Grid_Construction_Test()
        {
            // As per spec, upper boundaries (upper_x, upper_y) are
            // fed in as the first line of input.
            // Lower coordinates are assumed to be x = y = 0
            int top_x = 5;
            int top_y = 5;

            // Arrange - create objects to be tested 
            Grid grid = new Grid(top_x, top_y);

            // Act - perform actions on those objects
            grid.upper_x = top_x;
            grid.upper_y = top_y;

            // Assert - confirm that the actions performed create the results expected
            // Check that upper boundary is correct to the value supplied

            Assert.AreEqual(grid.upper_x, 5);
            Assert.AreEqual(grid.upper_y, 5);
        }

        [TestMethod]
        public void Rover_Construction_Test()
        {
            // Arrange
            string name = "MR 1";
            string number = "NASA_MER001";
            string initialPosition = "1 2 N";
            Rover rover = new Rover(name, number);

            // Act
            rover.GetInitialPosition(initialPosition);

            // Assert
            Assert.AreEqual(rover.name,"MR 1");
            Assert.AreEqual(rover.number,"NASA_MER001");
            Assert.AreEqual(rover.initialPosition,"1 2 N");
        }
    }
}
