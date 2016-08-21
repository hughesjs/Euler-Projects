using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
    static class Program
    {

        static bool IsPalindrome(int i, int j)
        {
            string toTest = (i * j).ToString();
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
        static void Main(string[] args)
        {
            long largestPalProd = 0;
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    if (IsPalindrome(i,j) && i*j > largestPalProd)
                    {
                        largestPalProd = i*j;
                    }
                }
            }
            Console.WriteLine(largestPalProd);
            Console.ReadLine();
        }
    }
}
