/*
 * 2 paskaita pdf
 * 72 skaidre
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis11
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmas, antras, trecias;
            Console.WriteLine("Iveskite pirma skaiciu");
            pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antras skaiciu");
            antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecias skaiciu");
            trecias = Convert.ToInt32(Console.ReadLine());

            switch (pirmas)
            {
                case 1:
                    Console.WriteLine("Pirmas skaicius lygus 1 ir triju skaiciu suma " + pirmas + " + " + antras + " + " + trecias + "  =" + (pirmas + antras + trecias));
                    break;
                case 2:
                    Console.WriteLine("Pirmas skaicius lygus 2 ir pirmo ir trecio skaiciu skirtumas " + pirmas + " - " + trecias + " = " + (pirmas - trecias));
                    break;
                case 3:
                    Console.WriteLine("Pirmas skaicius lygus 3 ir antro ir trecio skaiciu sandauga " + antras + " * " + trecias + " = " + (antras * trecias));
                    break;
            }
            Console.WriteLine();

            string gyvunas;
            Console.WriteLine("Iveskite gyvuno rusi");
            gyvunas = Console.ReadLine();

            switch (gyvunas.ToLower()) //tikrinimo metu visos raides paverciamos mazosiomis, galima patikrinti ir didziosiomis ir mazosiomis raidemis ivesta teksta
            {
                case "suo":
                    Console.WriteLine("Tai suo");
                    break;
                case "kate":
                    Console.WriteLine("Tai kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Tai ziurkenas");
                    break;

            }




       
        }
    }
}
