using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    [TestClass]
    [TestCategory("Decimal operations")]
    public class Decimal_operations
    {
        public static decimal n1;
        public static decimal n2;

        [ClassInitialize()]
        public static void FloatInitialize(TestContext testContext)
        {
            n1 = 10.5m;
            n2 = 5.0m;
        }

        [TestMethod]
        public void Test_add()
        {
            decimal sum = n2 + n1;
            Console.WriteLine(sum);
            Assert.AreEqual(15.5m, sum);
        }
        [TestMethod]
        public void Test_sub()
        {
            decimal sum = n1 - n2;
            Console.WriteLine(sum);
            Assert.AreEqual(5.5m, sum);
        }

        [TestMethod]
        public void Test_div()
        {
            decimal div = n1 / n2;
            Console.WriteLine(div);
            Assert.AreEqual(2.1m, div);
        }

        [TestMethod]
        public void Test_mod()
        {
            decimal mod = n1 % n2;
            Console.WriteLine(mod);
            Assert.AreEqual(0.5m, mod);

        }

    }
}