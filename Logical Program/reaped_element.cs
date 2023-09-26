using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class RepeatedElement
    {

        public RepeatedElement()
        {

            Console.Write("Enter the number of elements in the array: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int[] arr = new int[n];

                Console.WriteLine("Enter the elements of the array:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (arr[j] == arr[i])
                            {
                                Console.WriteLine($"The first repeated element is: {arr[i]}");
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input for element {i + 1}. Please enter a valid integer.");
                        i--; // Retry the same element
                    }
                }

                Console.WriteLine("No repeated elements found in the array.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of elements.");
            }

        }


    }
}
