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
        [TestMethod]
        public void Switch_Statement()
        {
            string weekDay = "";
            int dayNumber = 3;

            switch(dayNumber)
            {
                case 1:
                    weekDay = "monday";
                    break;
                case 2:
                    weekDay = "tuesday";
                    break;

                case 3:
                    weekDay = "wednesday";
                    break;

                case 4:
                    weekDay = "thursday";
                    break;

                case 5:
                    weekDay = "friday";
                    break;

                default:
                    weekDay = "weekend";
                    break;
            }
            Assert.AreEqual("wednesday", weekDay);
        }

        [TestMethod]
        public void Continue_break()
        {
            int n1 = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                n1 += i;
            }
            Assert.AreEqual(40, n1);
        }
    }
}
