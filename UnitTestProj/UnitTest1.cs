using Microsoft.VisualStudio.TestTools.UnitTesting;
using CL;
using System;

namespace UnitTestProj
{
    [TestCategory("General test Practise")]
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = CL.Class1.Addition(2,3);
            Assert.AreEqual(6, result);
        }
    }

    [TestCategory("String Class Practise")]
    [TestClass]
    public class UnitTest_String_Class
    {
        [TestMethod]
        public void Using_string_class()
        {
            string myStrig = "I had a nice dearm today, I was in Mexico";
            string newString = myStrig.Substring(0,12);

            Console.WriteLine(newString);
        }
    }


    [TestCategory("Overloding Methods")]
    [TestClass]
    public class Testing_methods_calls
    {
        [TestMethod]
        public void Overlodaed_with_int()
        {
            Employee emp = new Employee(1234, "Jonny", "Bravo", "Manager");
            string res = emp.PayType(1234);

            Console.WriteLine(res);
        }

        [TestMethod]
        public void Overlodaed_with_string()
        {
            Employee emp = new Employee(1234, "Jonny", "Bravo", "Manager");
            string res = emp.PayType(emp.JobDescription);

            Console.WriteLine(res);
        }

        [TestMethod]
        public void Tuple_practise()
        { 
            Tuple<int, string, bool> tuple = new Tuple< int, string, bool> (1, "cat", true);

            if (tuple.Item1 == 1)
            {
                Console.WriteLine(tuple.Item1);
            }


            if (tuple.Item2 == "cat")
            {
                Console.WriteLine(tuple.Item2);
            }

            if (tuple.Item3 == true)
            {
                Console.WriteLine(tuple.Item3);
            }
        }

    }

    []



}
