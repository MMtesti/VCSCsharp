/*
2 paskaita pdf

66 skaidre
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis10
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmas, antras, trecias;

            Console.WriteLine("Iveskite pirma skaiciu.");
            pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu.");
            antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu.");
            trecias = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras && pirmas > trecias)
            {
                Console.WriteLine("Pirmas skaicius yra didziausas.");
            }
            else if (antras > pirmas && antras > trecias)
            {
                Console.WriteLine("Antras skaicius didziausias.");
            }

            else
            {
                Console.WriteLine("Trecias skaicius yra didziausias.");
            }

            Console.WriteLine("Iveskite egzamino rezultatą.");
            int rezultatas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (rezultatas >=8 && rezultatas <= 10)
            {
                Console.WriteLine("Rezultatas patenka į [8 -10] balų skalę");
            }
            if (rezultatas >= 5 && rezultatas <  8)
            {
                Console.WriteLine("Rezultatas patenka į [5 -8] balų skalę");
            }

            if (rezultatas < 5)
            {
                Console.WriteLine("Rezultatas yra < 5 balų");
            }

        }
    }
}
