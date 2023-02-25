using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CL;

namespace OOP_tests
{
    [TestCategory("Trip unit tests")]
    [TestClass]
    public class Trip_tests
    {
       static double totalCost;
       static double totalDistance;
       static double totalLiters;
        [ClassInitialize()]
        public static void TripCalssInit(TestContext testContext)
        {
            totalCost = 25.00;
            totalDistance = 100.00;
            totalLiters = 10.00;
        }


        [TestMethod]
        public void Cost_Of_Trip()
        {
            // arrange
            Trip trip1 = new Trip("Sligo", 25, 23.00, 3.4);
            // act
            var cost = trip1.CostPerKilometer( totalCost, totalDistance);
            //assert
            Assert.AreEqual(.25, cost);
        }

        [TestMethod]
        public void Kilometers_Per_Liter()
        {
            // arrange
            Trip trip1 = new Trip("Sligo", 25, 23.00, 3.4);
            // act
            var retult = trip1.KilometersPerLiter(totalDistance, totalLiters);
            //assert
            Assert.AreEqual(10, retult);
        }


        [TestMethod]
        public void Trip_to_string_test()
        {
            // arrange
            Trip trip1 = new Trip("Sligo", 25, 23.00, 3.4);
            // act
            Console.WriteLine(trip1.ToString());
        }

    }
}
