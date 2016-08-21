using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Euler_25
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            BigInteger l1 = 1;
            BigInteger l2 = 1;
            int index = 3;
            BigInteger current = l1 + l2;
            while (current.ToString().Length < 1000)
            {
                l2 = l1;
                l1 = current;
                current = l1 + l2;
                index++;
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime-startTime);
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
