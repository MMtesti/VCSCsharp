/*
 * 2 paskaita pdf. 31 skaidre ir 35 skaidre su trizenklio skaiciaus skaidymu
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis6
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius;
            Console.WriteLine("Įveskite sveiką skaičių ");
            skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jūsų skaičiaus daugybos lentelė iki 5: ");
            Console.WriteLine("{0} * 1 = {1}", skaicius, (skaicius * 1));
            Console.WriteLine("{0} * 2 = {1}", skaicius, (skaicius * 2));
            Console.WriteLine("{0} * 3 = {1}", skaicius, (skaicius * 3));
            Console.WriteLine("{0} * 4 = {1}", skaicius, (skaicius * 4));
            Console.WriteLine("{0} * 5 = {1}", skaicius, (skaicius * 5));
            Console.WriteLine();

            Console.WriteLine("Įveskite pirmą skaičių ");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių ");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių ");
            int trecias = Convert.ToInt32(Console.ReadLine());
            double vidurkis = (pirmas + antras + trecias) / 3;
            vidurkis = Math.Round(vidurkis, 2);
            Console.WriteLine("Jūsų pasirinkti skaičiai yra {0}, {1} ir {2}. Jų vidurkis {3}", pirmas, antras, trecias, vidurkis);
            Console.WriteLine();


            Console.WriteLine("Įveskite pirmą skaičių ");
            pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių ");
            antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių ");
            trecias = Convert.ToInt32(Console.ReadLine());
            double dalmuo1 = (double)pirmas / 2;
            dalmuo1 = Math.Round(dalmuo1, 2);
            double dalmuo2 = (double)antras / 2;
            dalmuo2 = Math.Round(dalmuo2, 2);
            double dalmuo3 = (double)trecias / 2;
            dalmuo3 = Math.Round(dalmuo3, 2);

            Console.WriteLine("Pasirinkti skaičiai:" + pirmas + ", " + antras + ", " + trecias);
            Console.WriteLine("Jų kvadratai: " + (Math.Pow(pirmas, 2)) + ", " + (Math.Pow(antras, 2)) + ", " + (Math.Pow(trecias, 2)));
            Console.WriteLine("Jų kubai: " + (Math.Pow(pirmas, 3)) +  ", " + (Math.Pow(antras, 3)) + ", " + (Math.Pow(trecias, 3)));
            Console.WriteLine("Jų dalyba iš 2 jų: " + dalmuo1 + ", " + dalmuo2 + ", " + dalmuo3 );


            double pirmass, vidurinis, paskutinis, trizenklis = 256; 
            paskutinis = trizenklis % 10;
            vidurinis = (((trizenklis - paskutinis) / 10)) % 10;
            pirmass = (trizenklis - (trizenklis % 100)) / 100;
            pirmass = Math.Round(pirmass);

            Console.WriteLine("Triženklį skaičių sudaro {0}, {1} ir {2}. Jų sandauga lygi {3}", pirmass, vidurinis, paskutinis,
            (pirmass * vidurinis * paskutinis));

            // arba naudojant masyvus galima istraukti atskirus daugiazenklio skaiciaus skaicius

            

        }
    }
}
