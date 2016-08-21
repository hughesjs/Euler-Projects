using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler_20
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime starTime = DateTime.Now;
            string numString = factorial(100).ToString();
            int digitSum = 0;
            foreach (char digit in numString)
            {
                digitSum += Convert.ToInt32(char.GetNumericValue(digit));
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(digitSum);
            Console.WriteLine(endTime - starTime);
            Console.ReadLine();
        }

        static BigInteger factorial(int num)
        {
            BigInteger fact = num;
            for (int i = num; i > 0; i--)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
