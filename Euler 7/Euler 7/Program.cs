using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int primesFound = 0;
            int i = 2;
            int lastPrime = 0;
            do
            {
                if (IsPrime(i))
                {
                    primesFound++;
                    lastPrime = i;
                }
                i++;
            } while (primesFound < 10001);
            Console.WriteLine(lastPrime);
            Console.ReadLine();
        }

        static bool IsPrime(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i%j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
