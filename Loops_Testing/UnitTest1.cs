using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Loops_Testing
{
    [TestClass]
    [TestCategory("Loops And Repetitions")]
    public class LoopTesing
    {
        [TestMethod]
        public void Counter_Controlled_Loop()
        {
            int number = 0;
            while(number < 10)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void Do_While_Loop()
        {
            int enterredValue = 0, sum = 0;
            do
            {
                sum += enterredValue;
                enterredValue++;
            }
            while (enterredValue <= 10 );

            Assert.AreEqual(55, sum);
        }
    }
}
