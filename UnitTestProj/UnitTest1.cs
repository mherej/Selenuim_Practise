using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProj
{
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
}
