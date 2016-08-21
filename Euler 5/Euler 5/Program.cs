using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = true;
            int num = 20;
            do
            {
                num++;
                found = true;
                for (int i = 1; i <= 20; i++)
                {
                    if (num%i != 0)
                    {
                        found = false;
                        break;
                    }
                }
            } while (!found);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
