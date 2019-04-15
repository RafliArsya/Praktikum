using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limas_Segitiga
{
    class Program
    {
        static void Main(string[] args)
        {
            float luas, alas, tinggi, tinggi_, volume;
            const float set = 0.5f, sep = 0.33f;
            string nama = "YUSUF RAFLI B", nim = "21120118130101";
            int shift = 4;//, Kelompok=51;
            char[] Kelompok = { 'L', 'I' };

            Console.Write("Nama : {0}, NIM : {1}\nKelompok : {2}{3}, Shift : {4}\n", nama, nim, Kelompok[0], Kelompok[1], shift);
            Console.Write("Masukkan alas : ");

            while (!float.TryParse(Console.ReadLine(), out alas))
            {
                Console.WriteLine("Format Masukan Salah!\nMasukan kembali nilai alas : ");
            }
            Console.Write("Masukkan tinggi segitiga : ");
            while (!float.TryParse(Console.ReadLine(), out tinggi))
            {
                Console.WriteLine("Format Masukan Salah!\nMasukan kembali nilai tinggi segitiga : ");
            }
            Console.Write("Masukkan tinggi limas : ");
            while (!float.TryParse(Console.ReadLine(), out tinggi_))
            {
                Console.WriteLine("Format Masukan Salah!\nMasukan kembali nilai tinggi limas : ");
            }
            
            luas = alas * tinggi * set;
            volume = sep * luas * tinggi_;
            Console.WriteLine("Luas Limas Segitiga = 1/3 * luas alas * tinggi limas\nLuas Limas Segitiga = 1/3 * {0} * {1} = {2}", luas, tinggi_, volume);

            Console.ReadKey();
        }
    }
}
