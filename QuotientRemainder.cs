using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientRemainder
    {
        public static void CalculateQuotientRemainder()
        {
            Console.WriteLine("Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient : " + quotient);
            Console.WriteLine("Reminder : " + remainder);
        }
    }
}