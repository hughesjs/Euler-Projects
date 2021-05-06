using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_14
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            long biggestCollatzSequence = 0;
            long biggestNum = 0;
            for (long i = 1; i < 1000000; i++)
            {
                long collatzNum = getCollatz(i);
                if (collatzNum > biggestCollatzSequence)
                {
                    biggestCollatzSequence = collatzNum;
                    biggestNum = i;
                }
            }
            DateTime endTime  = DateTime.Now;
            Console.WriteLine(biggestNum);
            Console.WriteLine(biggestCollatzSequence);
            Console.WriteLine(endTime - startTime);
            Console.ReadLine();
        }

        static long getCollatz(long i)
        {
            int steps = 0;
            while (i != 1)
            {
                if (i%2 == 0)
                {
                    i /= 2;
                }
                else
                {
                    i = 3*i + 1;
                }
                steps++;
            }
            return steps;
        }
    }
}
