using Microsoft.VisualStudio.TestTools.UnitTesting;
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
}
