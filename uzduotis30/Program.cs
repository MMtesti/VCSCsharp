/*
 * 4 paskaita pdf, 49 skaidre
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis30
{
    class Salis
    {
        public string Pavadinimas;
        public string Prezidentas;
        public int Plotas;
        public int GyventojuSkaicius;
        public double VidutinisAtlyginimas; // LT Valstybės nustatytas 2021 metais VDU dydis - 1352,7 EUR. 
        int[] Augimas = new int[5]; // LT augimas nuo 2015 iki 2019 m.

        public Salis(string pavadinimas, string prezidentas)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
        }
        public Salis(string pavadinimas, int gyventojuSkaicius, int a, int b, int c, int d, int e)
        {
            Pavadinimas = pavadinimas;
            GyventojuSkaicius = gyventojuSkaicius;
            Augimas[0] = a;
            Augimas[1] = b;
            Augimas[2] = c;
            Augimas[3] = d;
            Augimas[4] = e;
        }
        public Salis(string pavadinimas, double vidutinisAtlyginimas)
        {
            Pavadinimas = pavadinimas;
            VidutinisAtlyginimas = vidutinisAtlyginimas;
        }
        public Salis(string pavadinimas, string prezidentas, int plotas, int gyventojuSkaicius, double vidutinisAtlyginimas, int a, int b, int c, int d, int e)
        {
            Pavadinimas = pavadinimas;
            Prezidentas = prezidentas;
            Plotas = plotas;
            GyventojuSkaicius = gyventojuSkaicius;
            VidutinisAtlyginimas = vidutinisAtlyginimas;
            Augimas[0] = a;
            Augimas[1] = b;
            Augimas[2] = c;
            Augimas[3] = d;
            Augimas[4] = e;
        }
        public void Informacija()
        {
            Console.WriteLine($"Informacija apie šalį: pavadinimas - {Pavadinimas}, prezidentas - {Prezidentas}, šalies plotas - {Plotas} kv.m. Gyvena " +
                $"{GyventojuSkaicius} gyventojų. Šalies vidutinis atlyginimas  - {VidutinisAtlyginimas} eurų.");
            Console.Write($"Penkių metų gyventojų augimas (gimstamumas per metus): ");

            foreach (int item in Augimas)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
        public void MasyvoReiksme(int n)
        {

            if (n <= Augimas.Length - 1 && n >= 0)
            {
                Console.WriteLine("Masyvo elementas " + Augimas[n] + ", ");
                if (n + 1 <= Augimas.Length - 1)
                {
                    if (Augimas[n] > Augimas[n + 1])
                   {
                        Console.WriteLine("Kitas masyvo elementas " + Augimas[n + 1]);
                   }
                }
                else
                {
                    Console.WriteLine($" {n + 1} nepatenka į masyvo rėžius");
                }
            }
            else
            {
                Console.WriteLine($" {n} nepatenka į masyvo rėžius");
            }
        }
    }
     class Program
     {
         static void Main(string[] args)
         {
             Salis Lietuva = new Salis("Lietuva", "G.Nausėda", 65300, 2795700, 1352.7, 31475, 30623, 28696, 28149, 27393);
             Salis Latvija = new Salis("Latvija", "E.Levitas");
             Salis Estija = new Salis("Estija", 1328439, 12230, 10453, 11023, 10852, 10233);
             Salis Lenkija = new Salis("Lenkija", 1319);

             Lietuva.Informacija();
             Latvija.Informacija();
             Estija.Informacija();
             Lenkija.Informacija();
             Console.WriteLine("Įveskint indekso numerį nuo 1 iki 4");
             int indeksas = Convert.ToInt32(Console.ReadLine());
             Lietuva.MasyvoReiksme(indeksas);
        }
     }   
}
