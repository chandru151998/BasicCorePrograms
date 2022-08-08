using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap \n a = " + a + " b = " + b );
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap \n a = " + a + " b = " + b);
        }
    }
}