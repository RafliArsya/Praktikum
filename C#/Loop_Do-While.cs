using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perulangan_dowhile_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 1;
            do
            {
                Console.WriteLine("perulangan do while ke-" + angka);
                angka++;
            } while (angka <= 5);

            Console.ReadLine();
        }
    }
}
