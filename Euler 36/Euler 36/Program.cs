using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_36
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            long sum = 0;
            for (long i = 1; i < 1000000; i++)
            {
                if (IsPalindrome(Convert.ToString(i, 2)) && IsPalindrome(i.ToString()))
                {
                    sum += i;
                }
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(sum);
            Console.WriteLine(endTime - startTime);
            Console.ReadLine();
        }

        static bool IsPalindrome(string toTest)
        {
            int endPointer = toTest.Length - 1;
            int startPointer = 0;
            while (startPointer <= endPointer)
            {
                if (toTest[startPointer] != toTest[endPointer])
                {
                    return false;
                }
                startPointer++;
                endPointer--;
            }
            return true;
        }
    }
}
