using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Euler_12
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong i = 1;
            ulong triangle = 1;
            while (GetFactors(triangle) < 500)
            {
                triangle += ++i;
            }
            Console.WriteLine(triangle);
            Console.ReadLine();
        }
        static int GetFactors(ulong num)
        {
            int factors = 0;
            for (ulong i = 1; i < num/2 + 1; i++)
            {
                if (num % i == 0)
                {
                    factors++;
                }
            }
            return factors;
        }
    }

}
