using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Factorial
    {
       
        public Factorial()
        {
            Console.WriteLine("choose number for factorial: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++) 
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);

        }
        
    }
}
