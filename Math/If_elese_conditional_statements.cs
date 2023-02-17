using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    [TestCategory("If else conditions")]
    [TestClass]
    public class If_elese_conditional_statements
    {
        static int n1, n2; 

        [ClassInitialize()]
        public static void IfElseConditionsTestContextInit(TestContext testContext)
        {
            n1 = 10; 
            n2 = 5; 
        }
        [TestMethod]
        public void n1_is_equal_n2()
        {
            if (n1 == n2)
            {
                Assert.IsTrue(n1 == n2);
            }
        }
        [TestMethod]
        public void n1_isnot_equal_n2()
        {
            if (n1 != n2)
            {
                Assert.IsTrue(n1 != n2);
            }
        }
        [TestMethod]
        public void n1_is_greater_than_n2()
        {
            if (n1 > n2)
            {
                Assert.IsTrue(n1 > n2);
            }
        }
        [TestMethod]
        public void n1_is_less_than_n2()
        {
            if (n1 < n2)
            {
                Assert.IsTrue(n1 < n2);
            }
        }
    }
}
