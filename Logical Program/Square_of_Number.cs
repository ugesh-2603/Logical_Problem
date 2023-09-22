using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Square_of_Number
    {
        public Square_of_Number(double a, double b)
        {
            double sumSquared = CalculateSquareOfSum(a, b); // Call the function to calculate the square of the sum
            Console.WriteLine($"Square of the sum: {sumSquared}"); // Display the result

            // Calculate and display the square of the difference
            double diffSquared = CalculateSquareOfDifference(a, b); // Call the function to calculate the square of the difference
            Console.WriteLine($"Square of the difference: {diffSquared}"); // Display the result
        }

        // Function to calculate the square of the sum
        static double CalculateSquareOfSum(double num1, double num2)
        {
            double sum = num1 + num2; // Calculate the sum of the two numbers
            return sum * sum; // Calculate and return the square of the sum
        }

        // Function to calculate the square of the difference
        static double CalculateSquareOfDifference(double num1, double num2)
        {
            double difference = num1 - num2; // Calculate the difference between the two numbers
            return difference * difference; // Calculate and return the square of the difference
        }

    }
}
    

