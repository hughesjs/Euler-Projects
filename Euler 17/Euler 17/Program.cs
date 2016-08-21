using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_17
{
    class Program
    {
        private static Dictionary<int, string> equivalents;
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            equivalents = new Dictionary<int, string>();
            equivalents.Add(0, "");
            equivalents.Add(1, "One");
            equivalents.Add(2, "Two");
            equivalents.Add(3,"Three");
            equivalents.Add(4, "Four");
            equivalents.Add(5, "Five");
            equivalents.Add(6, "Six");
            equivalents.Add(7, "Seven");
            equivalents.Add(8, "Eight");
            equivalents.Add(9, "Nine");
            equivalents.Add(10, "Ten");
            equivalents.Add(11, "Eleven");
            equivalents.Add(12, "Twelve");
            equivalents.Add(13, "Thirteen");
            equivalents.Add(14, "Fourteen");
            equivalents.Add(15, "Fifteen");
            equivalents.Add(16, "Sixteen");
            equivalents.Add(17, "Seventeen");
            equivalents.Add(18, "Eighteen");
            equivalents.Add(19, "Nineteen");
            equivalents.Add(20, "Twenty");
            equivalents.Add(30, "Thirty");
            equivalents.Add(40, "Forty");
            equivalents.Add(50, "Fifty");
            equivalents.Add(60, "Sixty");
            equivalents.Add(70, "Seventy");
            equivalents.Add(80, "Eighty");
            equivalents.Add(90, "Ninety");
            equivalents.Add(100, "Hundred");
            equivalents.Add(1000, "Thousand");
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += toText(i).Length;
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(sum);
            Console.WriteLine(endTime-startTime);
            Console.ReadLine();
            /*while (true)
            {
                Console.WriteLine(toText(Convert.ToInt32(Console.ReadLine())));
            }*/
        }

        static string toText(int number)
        {
            string numString = number.ToString();
            numString = numString.PadLeft(4, '0');
            string returnString = "";
            if (numString[0] != '0')
            {
                returnString = returnString + equivalents[Convert.ToInt32(char.GetNumericValue(numString[0]))] + " Thousand ";
            }
            if (numString[1] != '0')
            {
                returnString = returnString + equivalents[Convert.ToInt32(char.GetNumericValue(numString[1]))] + " Hundred ";
            }
            if ((numString[2] == '1' || numString[2] == '0') && numString[2]!= '0')
            {
                returnString = returnString + "and " + equivalents[Convert.ToInt32(char.GetNumericValue(numString[2]))*10 + Convert.ToInt32(char.GetNumericValue(numString[3]))];
            }
            else if ((!(numString[2]=='0' && numString[3]=='0')))
            {
                returnString = returnString + "and " +
                               equivalents[Convert.ToInt32(char.GetNumericValue(numString[2]))*10] + " " +
                               equivalents[Convert.ToInt32(char.GetNumericValue(numString[3]))];
            }
            else if ((numString[2] != '0' && numString[3] == '0'))
            {
                returnString = returnString + " and " +
                               equivalents[Convert.ToInt32(char.GetNumericValue(numString[2]))*10];
            }
            if (returnString.IndexOf("and") == 0)
            {
                returnString = returnString.Replace("and", "");
            }
            return returnString.Replace(" ","");
        }
    }
}
