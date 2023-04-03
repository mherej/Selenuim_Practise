using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CL;

namespace OOP_tests
{
    [TestCategory("Person/Student tests")]
    [TestClass]
    public class Person_Student_UT
    {
        [TestMethod]
        public void Person_Student_class()
        {
            Person person = new Person("JHonny", "Bravo", 33);
            Student student = new Student("Jenny", "Brown", 33, "34343", "Software development");

        }


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
                if (isCarFamily == true)
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
                DateTime emp1StartDate = new DateTime(2012, 01, 01);
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

            [TestMethod]
            public void Test_Employee_Constuctor()
            {
                //arrange
                Employee emp2 = new Employee(1, "Jonhny", "Bravo", "Manager");
                // act
                emp2.JobDescription = "Staff";
                // assert
                Assert.AreEqual(emp2.JobLocation(), "Chicago");
            }

            [TestMethod]
            public void Test_Employee_ToSting()
            {
                //arrange
                Employee emp2 = new Employee(1, "Jonhny", "Bravo", "Manager");
                // act
                Console.WriteLine(emp2);
                // assert
                //Assert.AreEqual(emp2.JobLocation(), "Chicago");
            }
        }
    }
}
