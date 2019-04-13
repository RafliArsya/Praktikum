using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengkondisian_if_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai;
            nilai = 45;
            if (nilai > 0 && nilai < 80) {
                Console.WriteLine("Success Condition");
                Console.ReadLine();
            }
        }
    }
}
