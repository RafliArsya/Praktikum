using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] larik = new int[3, 3];
            larik[0, 0] = 1;
            larik[1, 1] = 2;
            larik[2, 2] = 3;
            larik[0, 1] = larik[0, 0] + larik[1, 1];
            larik[1, 2] = larik[1, 1] + larik[2, 2];
            larik[0, 2] = larik[0, 1] + larik[1, 2];
            larik[1, 0] = larik[0, 0] * larik[1, 1];
            larik[2, 1] = larik[1, 1] * larik[2, 2];
            larik[2, 0] = larik[1, 0] * larik[2, 1];
            for (int i=0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (larik[i, j] < 10)
                    {
                        Console.Write(" " + larik[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(larik[i, j] + " ");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
