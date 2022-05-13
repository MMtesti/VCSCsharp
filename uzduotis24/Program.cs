/*
 * 3 paskaita pdf, 76 skaidre
 * 77 skaidre su string isvedimu
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičius:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičius:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičius:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įvesti skaičiai " + a + " " + b + " " + c);
            Console.WriteLine("Jų suma " + Suma(a, b, c));
            Console.WriteLine("Dalyba: " + Dalyba(a, b));
            Console.WriteLine();
            Console.WriteLine("Įveskite vardą");
            string kreipinys = Console.ReadLine();
            Console.WriteLine(Kreipinys(kreipinys));
        }
        public static int Suma(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Dalyba(int x, int y)
        {
            double dalmuo = (double)x / y;
            dalmuo = Math.Round(dalmuo, 2);
            return dalmuo;
        }
        public static string Kreipinys( string vardas)
        {
            string ats = $"Sveiki, {vardas}";
            return ats;
        }
    }
}
