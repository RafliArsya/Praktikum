using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Kelompok51
{
    class Program
    {

        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Berapa objek?");
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Format Masukan Salah!\nMasukan kembali banyak objek! ");
            }
            smartphone[] hp = new smartphone[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Merk objek ke {0} :", i+1);
                string brand = Console.ReadLine();
                Console.WriteLine("Pembeli objek ke {0} :", i + 1);
                string owner = Console.ReadLine();
                Console.WriteLine("Garansi objek ke {0} :", i + 1);
                string warranty = Console.ReadLine();
                Console.WriteLine("Harga objek ke {0}", i + 1);
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Status objek ke {0}", i + 1);
                string status = Console.ReadLine();
                hp[i] = new smartphone(brand, owner, warranty, price, status);
            }
            for (int i = 0; i < count; i++)
            {
                hp[i].print("Smartphone bermerk" + hp[i].merk_() + ", Pemilik " + hp[i].owner_() + ", Garansi " + hp[i].warranty_() + ", dengan harga " + hp[i].price_() + ", kondisi/status barang " + hp[i].status_() + ".");
            }
            Console.ReadKey();
        }
    }
}
