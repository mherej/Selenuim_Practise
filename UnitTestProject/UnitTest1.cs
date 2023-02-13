using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("LoginFeature")]

    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("Positive")]
        [Description("The description")]/// description is only valid attribute for the method
        public void TestMethod1()
        {
            int a = 1, b = 3;
            Assert.AreEqual(4, a + b);
        }

        [TestMethod]
        [TestCategory("Negative")]
        public void TestMethod2()
        {
            int a = 1;
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [TestCategory("Negative")]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            int a = 1;
            Assert.AreNotEqual(1, a);
        }
    }
    // Quiz
    // creata a new unit test class
    // add three methods
    // one check 1 + 1 
    // one automatically fails usidng a special fails assertion method
    // checks 10 + 10 ==21 and fails 
    [TestClass]
    [TestCategory("QIUZ")]
    public class Unit2
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1, b = 1;
            Assert.AreEqual(2, a + b);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail();
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            int a = 10, b = 10;
            Assert.AreEqual(21, a + b);
        }

        [TestClass]
        [TestCategory("TestInitialize")]
        public class Unit3
        {
            private int a;
            private static TestContext _testContext;

            [TestInitialize]// will execute before EVERY test method
            public void RunBeforeEveryTest()
            {
                a = 1;
            }
            [TestCleanup]
            public void RunAfterEveryTestMothod()
            {
                Trace.Write("Run after every test methos will execute after every single test method");
            }
            [ClassInitialize]
            public static void RunBeforeAllOftheTestMethods(TestContext testContext)
            {
                _testContext = testContext;
                Trace.WriteLine("Run one time before all test methods in the class");

            }
            [TestMethod]
            public void TestMethod1()
            {
                int b = 1;
                Assert.AreEqual(2, a + b);
            }
            [TestMethod]
            public void TestMethod2()
            {
                Assert.IsTrue(2 == 1 + 1);
            }
            [TestMethod]
            [ExpectedException(typeof(AssertFailedException))]
            public void TestMethod3()
            {
                Assert.AreEqual(11, a);
            }
        }
    }
}
