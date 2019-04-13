using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Percobaan1_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume, panjang, lebar, tinggi;
            panjang = 8;
            lebar = 2;
            tinggi = 4;
            volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume Balok adalah " + volume);

            Console.ReadKey();
        }
    }
}
