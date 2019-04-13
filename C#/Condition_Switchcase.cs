using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pengkodisian_switchcase_51
{
    class Program
    {
        static void Main(string[] args)
        {
            string nilai;
            Console.Write("masukan nilai (A-E): ");
            nilai = Console.ReadLine();

            switch (nilai)
            {
                case "A":
                case "a":
                    Console.WriteLine("nilai anda\t: {0} (80-100)", nilai);
                    Console.ReadLine();
                    break;
                case "B":
                case "b":
                    Console.WriteLine("nilai anda\t: {0} (70-79)", nilai);
                    Console.ReadLine();
                    break;
                case "C":
                case "c":
                    Console.WriteLine("nilai anda\t: {0} (60-69)", nilai);
                    Console.ReadLine();
                    break;
                case "D":
                case "d":
                    Console.WriteLine("nilai anda\t: {0} (50-59)", nilai);
                    Console.ReadLine();
                    break;
                case "E":
                case "e":
                    Console.WriteLine("nilai anda\t: {0} (0-49)", nilai);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("nilai salah");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
