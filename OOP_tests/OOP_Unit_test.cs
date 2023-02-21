using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CL;

namespace OOP_tests
{
    [TestCategory("Class tests")]
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

        [TestMethod]
        public void Car_Acceleration_test()
        {
            // arrange
            Car car = new Car(3, "red", true);
            // act
            car.Accelerate();
            // assert
            Assert.AreEqual(car.Color, "red");
        }


        [TestMethod]
        public void Car__test()
        {
            // arrange
            Car car = new Car(3, "red", true);
            // act
            bool isCarFamily = car.IsFamilityCar();
            // assert
            if(isCarFamily == true)
            {
                Assert.AreEqual(car.IsFamilityCar(), true);
            }
            else
            {
                Assert.Fail();
            }
            
        }

        [TestMethod]
        public void EmployeeNameCheck()
        {
            DateTime emp1StartDate = new DateTime(2012,01,01);
            //arrange
            Employee emp1 = new Employee(22, "Jonny", "Bravo", new DateTime(2012, 01, 01), "cashier", "sales", 2000.00M);
            // act
            // assert
            Assert.AreEqual(emp1.FullName, "Jonny Bravo");
        }

        [TestMethod]
        public void EmployeeNameSortCheck()
        {
            //arrange
            Employee emp2 = new Employee(22, "Jonny", "Bravo", new DateTime(2012, 01, 01), "cashier", "sales", 2000.00M);
            // act
            // assert
            Assert.AreEqual(emp2.SortableName, "Bravo, Jonny");
        }

    }
}
