using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class MathHelper
    {
        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public static int Sum (int x, int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static decimal Sum(decimal x, decimal y)
        {
            return x + y;
        }
    }
}
