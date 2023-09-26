using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class SubString
    {
        public SubString()

        {
            string input = "ABDEFGABEF";

            int maxLength = 0;

            int[] charIndex = new int[256]; 

            for (int i = 0, j = 0; j < input.Length; j++)
            {
                i = Math.Max(charIndex[input[j]], i);
                maxLength = Math.Max(maxLength, j - i + 1);
                charIndex[input[j]] = j + 1;
            }

            Console.WriteLine("Longest substring length in \"{0}\": {1}", input, maxLength);

        }

    }
}

