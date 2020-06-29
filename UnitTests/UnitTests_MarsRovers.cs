using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRovers;
using System.Text;

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

        // Test to create rover
        [TestMethod]
        public void Rover_Construction_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "1 2 N";

            // Act
            rover.SetRoverName("MR 1");
            rover.SetInitialPosition(position);
            rover.GetInstructions("RMRMLM");

            // Assert
            Assert.AreEqual(rover.name, "MR 1");
            Assert.AreEqual(rover.position, "1 2 N");
        }

        // Test change to rover's orientation to right 
        [TestMethod]
        public void Rover_Alter_OrientationToRight_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "1 2 N";

            // Act
            rover.position = position;
            rover.rotateRight("N");

            // Assert
            Assert.AreEqual("1 2 E", rover.position);
        }

        // Test change to rover's orientation to left
        [TestMethod]
        public void Rover_Alter_OrientationToLeft_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "1 2 N";

            // Act
            rover.position = position;
            rover.rotateLeft("N");

            // Assert
            Assert.AreEqual("1 2 W", rover.position);
        }

        // Test that an advance north will increase x value by one
        [TestMethod]
        public void Rover_AdvanceNorth_X_Direction_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "2 3 N";

            // Act  
            rover.position = position;
            rover.AdvanceY();

            // Assert
            Assert.AreEqual("2 4 N", rover.position);

        }

        // Test that an advance south will increase x value by one
        [TestMethod]
        public void Rover_AdvanceSouth_X_Direction_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "2 3 S";

            // Act  
            rover.position = position;
            rover.AdvanceY();

            // Assert
            Assert.AreEqual("2 2 S", rover.position);
        }

        // Test that an advance east will increase y value by one
        [TestMethod]
        public void Rover_AdvanceEast_Y_Direction_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "2 3 E";

            // Act  
            rover.position = position;
            rover.AdvanceX();

            // Assert
            Assert.AreEqual("3 3 E", rover.position);
        }

        // Test that an advance east will increase y value by one
        [TestMethod]
        public void Rover_AdvanceWest_Y_Direction_Test()
        {
            // Arrange
            Rover rover = new Rover();
            string position = "2 3 W";

            // Act  
            rover.position = position;
            rover.AdvanceX();

            // Assert
            Assert.AreEqual("1 3 W", rover.position);
        }
    }
}
