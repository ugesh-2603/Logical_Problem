using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Qyadratic_Equation
    {


        public Qyadratic_Equation()
        {
            Console.WriteLine("Quadratic Equation Solver");

            Console.Write("Enter the coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {

                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Root 1: {root1}");
                Console.WriteLine($"Root 2: {root2}");
            }
            else if (discriminant == 0)
            {

                double root = -b / (2 * a);
                Console.WriteLine($"Root: {root}");
            }
            else
            {

                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Root 1: {realPart} + {imaginaryPart}i");
                Console.WriteLine($"Root 2: {realPart} - {imaginaryPart}i");
            }
        }
    }
    
}
