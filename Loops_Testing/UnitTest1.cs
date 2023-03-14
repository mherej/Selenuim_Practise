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
        public void Sentinel_Controlled_Loop()
        {
            string enterredValue = "";
            while (enterredValue != "99")
            {
                Console.WriteLine("Enter the value [99 to exit]");
                enterredValue = Console.ReadLine();
            }
        }
    }
}
