using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_22
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            StreamReader reader = new StreamReader(@"C:\Users\James\Desktop\Euler22.txt");
            string namesString = reader.ReadToEnd();
            List<string> names = namesString.Split(',').ToList();
            names.Sort();
            long namesSum = 0;
            int position = 1;
            foreach (string name in names)
            {
                long sum = 0;
                foreach (char letter in name.Replace("\"", ""))
                {
                    sum += (letter - 64);
                }
                sum *= position;
                position++;
                namesSum += sum;
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(namesSum);
            Console.Write(endTime-startTime);
            Console.ReadLine();
        }
    }
}
