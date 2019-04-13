using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2];
            array[0, 0] = 3;
            System.Console.WriteLine("Datanya adalah " + array[0, 0]);
            Console.ReadKey();
        }
    }
}
