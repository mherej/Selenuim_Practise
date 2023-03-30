using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_list_test
{
    [TestClass]
    [TestCategory("Arrays Test Practise")]
    public class Arrays_tests
    {
        [TestMethod]

        public void For_each_loop()
        {
            int[] asores = { 1, 2, 3, 4, 5, 6, 7 };

            foreach(int i in asores)
            {
                Console.WriteLine($"Score: {i}");
            }
        }

        [TestMethod]
        public void Pass_array_test()
        {
            int[] scores = { 2, 3, 5, 6, 7, 8, 9 };
            var sum = totalScores(scores);
            Console.WriteLine(sum);
        }

        [TestMethod]
        public void Pass_array_element()
        {
            int [] scores = { 1, 2, 3, 4, 5 };

            foreach(int i in scores)
            {
                Check_for_score(i);
  
            }
        }

        private void Check_for_score(int i)
        {

            if (i >= 3)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        private  int totalScores(int[] scores)
        {
            int sum = 0;
            foreach(int s in scores)
            {
                sum += s;
            }
            return sum;
        }


    }
}
