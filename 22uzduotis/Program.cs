// 3 paskaita pdf 70-71 skaidres
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite vardą");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių");
            string amzius = Console.ReadLine();
            Console.WriteLine("Įveskite savo hobius");
            string hobis = Console.ReadLine();
            Kreipinys(vardas, amzius, hobis);
        }
        public static void ProgramosKreipinys()
        {
            Console.WriteLine("PROGRAMA PRADĖJO DARBĄ");

        }
        public static void Kreipinys(string vardas, string amzius, string hobiai)
        {
            Console.WriteLine($"Labas, {vardas} ( {amzius} m.)");
            Console.WriteLine($"Jūsų įrašytas hobis: {hobiai}");
        }
    }

}
