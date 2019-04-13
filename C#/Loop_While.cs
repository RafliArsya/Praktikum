using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perulangan_while_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 1;
            while (angka <= 5)
            {
                Console.WriteLine("perulangan while ke-" + angka);
                angka++;
            }
            Console.ReadLine();
        }
    }
}
