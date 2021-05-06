using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Euler_3
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                long bigNumber = Convert.ToInt64(Console.ReadLine());
                List<long> factors = GetFactors(bigNumber);
                Console.WriteLine(LargestPrime(factors));
                Console.ReadLine();
            }
        }

        private static List<long> GetFactors(long num)
        {
            List<long> factors = new List<long>();
            for (int i = 1; i < Math.Sqrt(num); i++)
            {
                if (num%i == 0)
                {
                    Console.WriteLine(i + " is a factor");
                    factors.Add(i);
                }
            }
            return factors;
        }

        private static int LargestPrime(List<long> toTest)
        {
            long biggestPrime = 0;
            foreach (long num in toTest)
            {
                
                if (num > biggestPrime && IsPrime(num))
                {
                    Console.WriteLine(num + " is a prime factor");
                    biggestPrime = num;
                }
            }
            return Convert.ToInt32(biggestPrime);
        }

        private static bool IsPrime(long num)
        {
            int factCount = 0;
            if (num%2 == 0 && num != 2)
            {
                return false;
            }
            for (long i = 2; i <= num; i++)
            {
                if (num%i == 0)
                {
                    factCount++;
                }
                if (factCount > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
