using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestAmongThreeNumbers
    {
        public static void LargestNumber()
        {
            int num1, num2, num3;
            Console.Write("Find the largest of three numbers \n\n");
            Console.Write("1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3rd  number : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("1st Number is the largest among three");
                }
                else
                {
                    Console.Write("3rd Number is the largest among three");
                }
            }
            else if (num2 > num3)
                Console.Write("2nd Number is the largest among three");
            else
                Console.Write("3rd Number is the largest among three");
        }
    }
}