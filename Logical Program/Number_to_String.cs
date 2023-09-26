using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Number_to_Strings
    {

        public Number_to_Strings()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string result = "";
            if (number % 3 == 0)
            {
                result += "Pling";
            }
            if (number % 5 == 0)
            {
                result += "Plang";
            }
            if (number % 7 == 0)
            {
                result += "Plong";
            }
            if (result == "")
            {
                result = number.ToString();
            }

            Console.WriteLine(result);
        }


    }
}
