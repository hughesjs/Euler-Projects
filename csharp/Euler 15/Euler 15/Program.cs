

using System;

namespace Euler_15
{
    internal static  class Prog
    {
        public static void Main()
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine(numPaths());
            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
            Console.ReadLine();
        }

        private static long numPaths()
        {
            long paths = 0;
            for (int i = 0; i < Math.Pow(2,20); i++)
            {
                for (int j = 0; j < Math.Pow(2, 20); j++)
                {
                    if (Convert.ToString(i, 2).PadLeft(15).Split('1').Length == 19 &&
                        Convert.ToString(i, 2).PadLeft(15).Split('0').Length == 19)
                    {
                        paths++;
                    }
                }
            }


            return paths;
        }
    }
}
