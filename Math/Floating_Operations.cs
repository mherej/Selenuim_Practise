using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    [TestClass]
    [TestCategory("Floating operations")]
    public class Floating_Operations
    {
        public static double n1;
        public static double n2;

        [ClassInitialize()]
        public static void FloatInitialize(TestContext testContext)
        {
            n1 = 10.5;
            n2 = 5.0;
        }

        [TestMethod]
        public void Test_add()
        {
            double sum = n2 + n1;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5, sum);
        }
        [TestMethod]
        public void Test_sub()
        {
            double sum = n1 - n2;
            Console.WriteLine(sum);
            Assert.AreEqual(5.5, sum);
        }

        [TestMethod]
        public void Test_div()
        {
            double div = n1 / n2;
            Console.WriteLine(div);
            Assert.AreEqual(2.1, div);
        }

        [TestMethod]
        public void Test_mod()
        {
            double mod = n1 % n2;
            Console.WriteLine(mod);
            Assert.AreEqual(0.5, mod);

        }
    }
}
