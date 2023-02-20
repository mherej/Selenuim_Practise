using Microsoft.VisualStudio.TestTools.UnitTesting;
using CL;

namespace OOP_tests
{
    [TestCategory("Car tests")]
    [TestClass]
    public class OOP_Unit_test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            Car car = new Car(3, "red", false);
            // act
            // assert
            Assert.AreEqual(car.Color, "red");

        }
    }
}
