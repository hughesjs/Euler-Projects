using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Euler_16
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            BigInteger bigNumber = 1;
            for (int i = 0; i < 1000; i++)
            {
                bigNumber *= 2;
            }
            string bigString = bigNumber.ToString();
            int sum = 0;
            foreach (char digit in bigString)
            {
                sum += Convert.ToInt32(char.GetNumericValue(digit));
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(sum);
            Console.WriteLine(endTime-startTime);
            Console.ReadLine();
        }
    }
}
