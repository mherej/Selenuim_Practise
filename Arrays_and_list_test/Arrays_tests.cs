using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
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

        [TestMethod]
        public void Array_List_Testing()
        {
            ArrayList scores = new ArrayList();
            fillthelist(scores);
            Console.WriteLine(scores.Count);

        }

        private void fillthelist(ArrayList scores)
        {
            for(int i = 0; i <=20; i++)
            {
                scores.Add(i);
            }
        }

        [TestMethod]
        public void Array_List_Quiz()
        {
            ArrayList dataList = new ArrayList();

            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

           decimal  totaSumOfValidItems = SumOfItems(RemoveStringItems(dataList));

           Console.WriteLine(totaSumOfValidItems);

        }

        public ArrayList RemoveStringItems(ArrayList listtosort)
        {
            ArrayList arrayList = new ArrayList();

            foreach (var item  in listtosort)
            {
                if (item is int)
                {
                    arrayList.Add(item);
                }
                else if (item is double)
                {
                    arrayList.Add(item);
                }
                else if (item is decimal)
                {
                    arrayList.Add(item);
                }
            }

            return arrayList;
        }

        public decimal SumOfItems(ArrayList list)
        {
            ArrayList sumal = new ArrayList();
            decimal sum = 0M;

            foreach (var item in list)
            {
                if (item is int || item is float || item is double || item is decimal || item is long)
                {
                    sum += Convert.ToDecimal(item);
                }
            }

            return sum;
        }
    }
}
