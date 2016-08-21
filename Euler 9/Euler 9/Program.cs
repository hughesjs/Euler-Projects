using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && a + b + c == 1000)
                        {
                            Console.WriteLine(a + ", " + b + ", " + c);
                            Console.ReadLine();
                            goto end;
                        }
                    }
                }
            }
            end:
            ;
        }
    }
}
