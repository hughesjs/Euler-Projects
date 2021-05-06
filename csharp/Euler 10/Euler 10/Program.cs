using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 2;
            int i = 3;
            while (i < 2000000)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
                i+=2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static bool IsPrime(int i)
        {
            for (int j = 2; j <= Math.Sqrt(i); j++)
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
