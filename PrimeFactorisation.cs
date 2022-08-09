﻿using System;
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
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }
            if (num > 2)
                Console.Write(num);
        }
    }
}
