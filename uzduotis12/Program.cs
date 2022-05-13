/*
 * 2 paskaita pdf
 * 78 skaidre
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Galimi pasirinkimai: 1 - stacionarus kompiuteris, 2 - nešiojamas kompiuteris, 3 - planšetė");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Stacionarus kompiuteris labiausiai tinka naudotis namie ar ofise");
                    break;
                case 2:
                    Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("Planšete patogu naudotis kelionių metu");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra!");
                    break;

            }
        }
    }
}
