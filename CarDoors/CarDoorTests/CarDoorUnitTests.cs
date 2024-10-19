using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDoors;

namespace CarDoorTests
{
    [TestClass]
    public class CarDoorUnitTests
    {
        [TestMethod]
        public void TestNonZero()
        {
            //Arrange
            CarDoorProvider carDoorProvider = new CarDoors.CarDoorProvider();
            carDoorProvider.SetDoors(5);
            int expected = 0;

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.AreNotEqual(expected, actual);


        }

        [TestMethod]
        public void TestIsEqual()
        {
            //Arrange
            CarDoorProvider carDoorProvider = new CarDoors.CarDoorProvider();
            carDoorProvider.SetDoors(5);
            int expected = 5;

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestIsNotNull()
        {
            //Arrange
            CarDoorProvider carDoorProvider = new CarDoors.CarDoorProvider();
            carDoorProvider.SetDoors(5);
            
            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestIsInteger()
        {
            //Arrange
            CarDoorProvider carDoorProvider = new CarDoors.CarDoorProvider();
            carDoorProvider.SetDoors(5);
            
            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.IsInstanceOfType(actual, typeof(int));
        }

        [TestMethod]
        public void TestAlwaysFails()
        {
            //Arrange
            CarDoorProvider carDoorProvider = new CarDoors.CarDoorProvider();
            carDoorProvider.SetDoors(5);
            int expected = 3;

            //Act
            int actual = carDoorProvider.GetDoors();

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
