using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Geometry
    {
        private static readonly double pi;
        public static double PI
        {
            get { return pi; }
        }

        static Geometry() 
        { 
            pi = 3.1416;
        }
        public static double CalculateCircleArea(double radius)
        {
            return PI * radius;
        }

        public static double CalculateRectangleArea(double width,double height)
        {
            return width * height;
        }
    }
}
