using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Percobaan4_51
{
    class Program
    {
        static void Main(string[] args)
        {
            float luas, alas, tinggi;
            string input;
            Console.WriteLine("Masukan alas\t:");
            input = Console.ReadLine();
            float.TryParse(input, out alas);

            Console.WriteLine("Masukan tinggi\t:");
            input = Console.ReadLine();
            float.TryParse(input, out tinggi);

            luas = (alas * tinggi) / 2;
            Console.WriteLine("Luas Segitiga adalah\t = {0}", luas);

            Console.ReadLine();
        }
    }
}
