using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelOrConsonant
    {
        public static void VowelConsonant()
        {
            Console.WriteLine("Type Charater");
            char z = Convert.ToChar(Console.ReadLine());
            if (z == 'a' || z == 'e' || z == 'i' || z == 'o' || z == 'u' || z == 'A' || z == 'E' || z== 'I' || z == 'O' || z == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonatnt");
            }
        }
    }
}