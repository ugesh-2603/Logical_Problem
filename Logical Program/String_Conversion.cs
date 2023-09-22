using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class String_Conversion
    {
        public static void String(string[] args)
        {
            // Read a number as a string from the user
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Parse the input string to an integer
            if (int.TryParse(userInput, out int number))
            {
                // Calculate 10 times the number and convert it back to a string
                string result = (number * 10).ToString();

                // Print the result
                Console.WriteLine("10 times the input number: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadLine();
        }

    }
}
