using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengkondisian_if_else_51
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            string angka;
            Console.WriteLine("Program bilangan bulat");
            Console.Write("Masukan angka = ");
            angka = Console.ReadLine();
            float.TryParse(angka, out a);
            if (a > 0)
            {
                Console.WriteLine("Bilangan bulat positif");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bilangan bulat negatif");
                Console.ReadLine();
            }
        }
    }
}
