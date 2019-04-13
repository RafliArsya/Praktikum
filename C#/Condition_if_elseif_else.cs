using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pengkodisian_if_elseif_else_51
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            string angka;
            Console.WriteLine("program bilangan bulat");
            Console.Write("masukan angka = ");
            angka = Console.ReadLine();

            float.TryParse(angka, out a);
            if (a== 0)
            {
                Console.WriteLine("angka = 0");
                Console.ReadLine();
            }else if (a > 0)
            {
                Console.WriteLine("bilangan bulat positif ");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("bilangan negatif ");
                Console.ReadLine();
            }
           
        }
        
    }
}
