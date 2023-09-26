using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Prime_Number
    {
        public Prime_Number()
        {
            static bool IsPrime(int number)
            {
                if (number <= 1)
                    return false;

                if (number <= 3)
                    return true;

                if (number % 2 == 0 || number % 3 == 0)
                    return false;

                for (int i = 5; i * i <= number; i += 6)
                {
                    if (number % i == 0 || number % (i + 2) == 0)
                        return false;
                }

                return true;
            }

            {
                Console.Write("Enter the number of elements in the array: ");
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    int[] numbers = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Enter element {i + 1}: ");
                        if (int.TryParse(Console.ReadLine(), out numbers[i]))
                        {
                            // Check if the number is prime and print it if it is
                            if (IsPrime(numbers[i]))
                            {
                                Console.WriteLine($"{numbers[i]} is a prime number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input for element {i + 1}. Please enter a valid integer.");
                            i--; // Retry the same element
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer for the number of elements.");
                }
            }
        }
    }
}

