using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_23
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for (int i = 1; i <= 28123; i++)
            {
                if (!isSumAbundant(i))
                {
                    sum += i;
                }
            }
        }
    }
}
