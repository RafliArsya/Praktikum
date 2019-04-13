using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1_Percobaan2_51
{
    class Program
    {
        static void Main(string[] args)
        {
            float r, keliling;
            const float phi = 3.14f;

            r = 6;
            keliling = 2 * phi * r;
            Console.WriteLine("Keliling Lingkaran = {0}", +keliling);

            Console.ReadKey();
        }
    }
}
