using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class shifting_the_number
    {
        public shifting_the_number() 
        {
            int[] array = new int[] { 12, 0, 42, 0, 4 };

            // Create a new array to store the non-zero elements
            int[] newArray = new int[array.Length];
            int nonZeroIndex = 0;

            // Iterate over the original array and move all non-zero elements to the new array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    newArray[nonZeroIndex] = array[i];
                    nonZeroIndex++;
                }
            }

            // Fill the rest of the new array with zeros
            for (int i = nonZeroIndex; i < array.Length; i++)
            {
                newArray[i] = 0;
            }

            // Copy the new array back to the original array
            array = newArray;

            // Print the resulting array
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
