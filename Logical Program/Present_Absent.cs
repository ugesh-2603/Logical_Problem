using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Present_Absent
    {
        public Present_Absent() 
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            // Check if the string contains all three characters.
            if (input.Contains("a") && input.Contains("e") && input.Contains("p"))
            {
                Console.WriteLine("All Present");
            }
            // Check if the string contains any of the three characters.
            else if (input.Contains("a") || input.Contains("e") || input.Contains("p"))
            {
                Console.WriteLine("One or more - Present");
            }
            // Otherwise, none of the characters are present.
            else
            {
                Console.WriteLine("None Present");
            }
        }
    }
}
