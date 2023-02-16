using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Math
{
    [TestCategory("Math Operations")]
    [TestClass]
    public class IntOperations
    {
        // set vars
        static int n1;
        static int n2;
    
        [ClassInitialize()]
        public static void IntInitalize(TestContext testContext)
        {
            n1 = 10;
            n2 = 5;
        } 

        [TestMethod]
        public void Test_Add()
        {
            int sum = n1 + n2;
            Console.WriteLine(sum);
            Assert.AreEqual(15, sum);
        }
        [TestMethod]
        public void Test_Sub()
        {
            Assert.AreEqual(5, n1 - n2);
        }
        [TestMethod]
        public void Test_Div()
        {
            Assert.AreEqual(2, n1 / n2);
        }
        [TestMethod]
        public void Test_Multi()
        {
            Assert.AreEqual(50, n2 * n1);
        }
        [TestMethod]
        public void Test_Modulus()
        {
            Assert.AreEqual(0, n1 % n2);
        }
    }
}
