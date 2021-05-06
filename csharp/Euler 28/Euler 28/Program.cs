using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Euler_28
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,] spiral = new long[5,5];
            long count = 1;
            int sideCount = 0;
            int sideLength = 1;
            bool right = true;
            bool up = false;
            bool vert = false;
            int row = 2;
            int col = 2;
            while (count <= 25)
            {
                if (sideCount < sideLength)
                {
                    spiral[row, col] = count;
                    count++;
                    sideCount++;
                    if (vert)
                    {
                        if (up)
                        {
                            row++;
                        }
                        else
                        {
                            row--;
                        }
                    }
                    else
                    {
                        if (right)
                        {
                            col++;
                        }
                        else
                        {
                            col--;
                        }
                    }
                }
                else
                {
                    if (vert)
                    {
                        if (up)
                        {
                            right = true;
                        }
                        else
                        {
                            right = false;
                        }
                        vert = false;
                    }
                    else
                    {
                        if (right)
                        {
                            up = false;
                        }
                        else
                        {
                            up = true;
                        }
                        vert = true;
                    }
                    sideCount = 1;
                    sideLength += 1;
                }
            }
            Console.WriteLine("Spiral Generated");
            Console.ReadLine();

        }
    }
}
