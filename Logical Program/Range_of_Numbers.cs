using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Range_of_Numbers
    {
        public Range_of_Numbers()
        {
            for (int num = 2000; num <= 3200; num++)
            {
                if (num % 7 == 0 && num % 5 != 0)
                {
                    Console.Write(num + ",");
                }
            }
        }
    }
}
