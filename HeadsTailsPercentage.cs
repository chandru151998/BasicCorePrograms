using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HeadsTailsPercentage
    {
        public static void CalculatePercentage()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage;
            double tailpercentage;
            Console.WriteLine("Enter the value for numbers of flip");
            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    if (number == 0)
                    {
                        headcount++;
                    }
                    {
                        tailcount++;
                    }
                }
                headpercentage = headcount * 100 / flipCoin;
                tailpercentage = tailcount * 100 / flipCoin;
                Console.WriteLine("Head percentage is " + headpercentage);
                Console.WriteLine("Tail percentage is " + tailpercentage);

            }
            else
            {
                Console.WriteLine("Please enter the positive number");
            }
        }
    }
}
