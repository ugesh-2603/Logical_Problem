using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Average_Q6
    {


        public Average_Q6()
        {
            // Create a Random object to generate random numbers
            Random random = new Random();

            // Initialize variables to store the sum of numbers and the generated numbers
            int sum = 0;
            string generatedNumbers = "";

            // Generate 5 random numbers and calculate the sum
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(10, 50); // Generates a random number between 10 and 50 (inclusive)
                sum += randomNumber;
                generatedNumbers += randomNumber + " ";

                // Print the generated numbers in one line
                Console.Write(randomNumber + " ");
            }

            // Calculate the average
            double average = (double)sum / 5;

            // Print a new line and the average
            Console.WriteLine("\nAverage: " + average);
        }
    }
}