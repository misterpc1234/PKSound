using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRovers;

namespace UnitTests
{
    [TestClass]
    public class MarsRoversTests
    {
        [TestMethod]
        public void Plateau_Construction_Test()
        {
            // As per spec, upper boundaries (upper_x, upper_y) are
            // fed in as the first line of input.
            // Lower coordinates are assumed to be x = y = 0
            int top_x = 5;
            int top_y = 5;

            // Arrange - create objects to be tested 
            Plateau plateau = new Plateau(top_x, top_y);

            // Act - perform actions on those objects
            plateau.upper_x = top_x;
            plateau.upper_y = top_y;

            // Assert - confirm that the actions performed create the results expected
            // Check that upper boundary is correct to the value supplied

            Assert.AreEqual(plateau.upper_x, 5);
            Assert.AreEqual(plateau.upper_y, 5);
        }

        [TestMethod]
        public void Rover_Construction_Test()
        {
            // Arrange
            string initialPosition = "1 2 N";
            string instructions = "RMRMLM";
            Rover rover = new Rover();

            // Act
            rover.GetInitialPosition(initialPosition);

            // Assert
            Assert.AreEqual(rover.name,"MR 1");
            Assert.AreEqual(rover.initialPosition,"1 2 N");
        }
    }
}
