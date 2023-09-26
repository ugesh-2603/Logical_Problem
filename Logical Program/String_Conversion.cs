using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class String_Conversion
    {
        public String_Conversion()
        {
            Console.Write("Enter a number as a string: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                Console.WriteLine("10 times of the number is: " + (number * 10).ToString());
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }
    }
}
