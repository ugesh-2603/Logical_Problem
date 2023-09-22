using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class CircleCalculator
    {
        public static double CalculatePerimeter(double diameter)
        {
            double radius = diameter / 2;
            return 2 * Math.PI * radius;
        }

        public static double CalculateArea(double diameter)
        {
            double radius = diameter / 2;
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
