using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CL;

namespace Math
{
    [TestClass]
    [TestCategory("Overloading practise")]
    public class Overloading_practise /// class access needs to be set to public to be visible on the test explorer
    {
        [TestMethod]
        public void Sqr_test()
        {
            //arrange
            //act
            double res = MathHelper.SquareRoot(4.0);
            //adssert
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void Sum_int_test()
        {
            //arrange
            //act
            int res = MathHelper.Sum(4,4);
            //adssert
            Assert.AreEqual(8, res);
        }
        [TestMethod]
        public void Sum_double_test()
        {
            //arrange
            //act
            double res = MathHelper.Sum(4.5, 4.5);
            //adssert
            Assert.AreEqual(9.0, res);
        }
        [TestMethod]
        public void Sum_decimal_test()
        {
            //arrange
            //act
            decimal res = MathHelper.Sum(4.5M, 4.5M);
            //adssert
            Assert.AreEqual(9, res);
        }
    }
}
