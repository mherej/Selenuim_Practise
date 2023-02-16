using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    [TestClass]
    [TestCategory("Math Quiz")]
    
    public class MathQuiz
    {
        static double c = 35.5;
        static double f = 67.5;
        [TestMethod]
        public void Cel_to_Far()
        {
            double farenheit = (c * 9 / 5) + 32;
            Console.WriteLine($"The temp in C {c} is {farenheit} in C");
        }


        [TestMethod]
        public void Far_to_Cel()
        {
            double celsius = (f - 32) * 5 / 9;
            Console.WriteLine($"The temp in F {f} is {celsius} in C");
        }
    }
}
