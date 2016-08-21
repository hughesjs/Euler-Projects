using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_21
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime starTime = DateTime.Now;
            int sum = 0;
            for (int a = 1; a < 10000; a++)
            {
                int b = d(a);
                    if (d(b) == a && (a != b))
                    {
                        sum += a;
                    }
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(sum);
            Console.WriteLine(endTime-starTime);
            Console.ReadLine();
        }

        static int d(int i)
        {
            int sum = 0;
            for (int j = 1; j < i/2 + 1; j++)
            {
                if (i%j == 0)
                {
                    sum += j;
                }
            }
            return sum;
        }
    }
}
