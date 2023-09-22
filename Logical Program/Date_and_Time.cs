using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Date_and_Time
    {
        static DateTime GetNextDay(DateTime date)
        {
            return date.AddDays(1);
        }
    }
}
