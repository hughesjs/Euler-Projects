using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            DateTime testDate = new DateTime(1901,1,1);
            DateTime endDate = new DateTime(2000,12,31);
            int numSundays = 0;
            while (testDate <= endDate)
            {
                if (testDate.DayOfWeek == DayOfWeek.Sunday && testDate.Day == 1)
                {
                    numSundays++;
                }

                testDate = testDate.AddDays(1);
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(numSundays);
            Console.WriteLine(endTime - startTime);
            Console.ReadLine();
        }
    }
}
