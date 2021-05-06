using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumSquare = 0;
            long squareSum = 0;
            for (int i = 0; i < 101; i++)
            {
                sumSquare += Convert.ToInt32(Math.Pow(i,2));
                squareSum += i;
            }
            squareSum = Convert.ToInt32(Math.Pow(squareSum,2));
            Console.WriteLine(sumSquare-squareSum);
            Console.ReadLine();
        }
    }
}
