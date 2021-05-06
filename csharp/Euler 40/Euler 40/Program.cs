using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_40
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            StringBuilder Champernowne = new StringBuilder();
            ulong count = 1;
            while (Champernowne.Length < 1000000)
            {
                Champernowne.Append(count);
                count++;
            }
            long prod = Convert.ToInt64(char.GetNumericValue(Champernowne[1-1]))*
                        Convert.ToInt64(char.GetNumericValue(Champernowne[10-1]))*
                        Convert.ToInt64(char.GetNumericValue(Champernowne[100-1]))*
                        Convert.ToInt64(char.GetNumericValue(Champernowne[1000-1]))*
                        Convert.ToInt64(char.GetNumericValue(Champernowne[10000-1]))*
                        Convert.ToInt64(char.GetNumericValue(Champernowne[100000-1]))*
                        Convert.ToInt64(char.GetNumericValue(Champernowne[1000000-1]));
            DateTime endTime = DateTime.Now;
            Console.WriteLine(prod);
            Console.WriteLine(endTime-startTime);
            Console.ReadLine();
        }
    }
}

