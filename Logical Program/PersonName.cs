using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class PersonName
    {
        public PersonName()
        {
            Console.Write("Enter a person's full name (First Name, Last Name, Middle Name(s) if any): ");
            string fullName = Console.ReadLine();

            // Split the full name into parts (First Name, Last Name, Middle Name(s))
            string[] nameParts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Count and print the number of parts in the name
            int numberOfParts = nameParts.Length;
            Console.WriteLine($"Number of parts in the name: {numberOfParts}");
        }
    }
}
