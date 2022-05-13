/*
 * 2 paskaita.pdf, 48 skaidre
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo amžių.");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            }

            Console.WriteLine("Tolimesnis tekstas");
            Console.WriteLine();

            Console.WriteLine("Įveskite bet kokį skaičių");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius < 0)
            {
                Console.WriteLine("Įvestas neteisingas skaičius!!!");
            }
            if (skaicius>=0)
            {
                Console.WriteLine("Sveikinu! Teisingai!");
            }
            if (skaicius % 2 == 0 )
            {
                Console.WriteLine("Sveikinu! Teisingai!");
            }
            if (skaicius % 4== 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            }

            if( skaicius > 10 )
            {
                Console.WriteLine("Skaičius didesnis už 10.");
            }

            int pirmas, antras, trecias, ketvirtas, penktas;
            double vidurkis;

            Console.WriteLine("Iveskite pirma pazymi.");
            pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra pazymi.");
            antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecia pazymi.");
            trecias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ketvirta pazymi.");
            ketvirtas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pirma pazymi.");
            penktas = Convert.ToInt32(Console.ReadLine());
            vidurkis = (pirmas + antras + trecias + ketvirtas + penktas) / 5;
            vidurkis = Math.Round(vidurkis, 1);
            Console.WriteLine();
            Console.WriteLine("Jusu ivestu pazymiu {0}, {1}, {2}, {3}, {4} vidurkis lygus {5}", pirmas, antras, trecias, ketvirtas, penktas, vidurkis);
            Console.WriteLine();

            if (vidurkis >= 5)
            {
                Console.WriteLine("Jusu vidurkis didesnis arba lygus 5");
            }


        }
    }
}
