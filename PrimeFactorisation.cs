using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PrimeFactorisation
    {
        public static void Factorization()
        {
            int b;
            Console.WriteLine("Please enter your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine(b + " is factor of " + a);
            }
        }
    }
}