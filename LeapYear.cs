using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LeapYear
    {
        public static void Year()
        {
            int year;
            Console.Write("Enter the Year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
        }
    }
}