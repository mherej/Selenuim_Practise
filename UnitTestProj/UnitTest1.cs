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
            int result = ClassLibrary2.Class1.Addition(2,3);
        }
    }
}
