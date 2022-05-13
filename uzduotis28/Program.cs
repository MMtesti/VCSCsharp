/*
 * 4 paskaita pdf. 39 skaidre ir 40 skaidre
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis28
{
    class Mokinys
    {
        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public int Klase;
        public List<int> Pazymiai = new List<int>();

        public Mokinys(string vardas, string pavarde, int amzius, int klase, int a, int b, int c, int d, int e)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Klase = klase;
            Pazymiai.Add(a);
            Pazymiai.Add(b);
            Pazymiai.Add(c);
            Pazymiai.Add(d);
            Pazymiai.Add(e);
        }
        public Mokinys( string vardas, string pavarde, int amzius)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
        }
        public void Informacija ()
        {
            Console.WriteLine($"Mokinys {Vardas} {Pavarde} mokinasi {Klase} klasėje. Jam yra {Amzius} metų.");
            Console.Write("Mokinio pažymiai: ");
            
            foreach (int item in Pazymiai)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void MoksluPabaiga()
        {
            int moksluPabaiga = 0;
            moksluPabaiga = 12 - Klase;
            
            if (moksluPabaiga == 0)
            {
                Console.WriteLine("Mokinys mokyklą baigs šiais metais");
            }
            else
            {
                Console.WriteLine($" Mokinys {Vardas} baigs mokyklą už {moksluPabaiga} metų.");
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mokinys mok1 = new Mokinys("Jonas", "Jonaitis", 12, 7, 6, 8, 7, 9, 8);
            Mokinys mok2 = new Mokinys("Adelė", "Palaimaitė", 12, 7, 8, 9, 7, 9, 10);
            Mokinys mok3 = new Mokinys("Augustas", "Petraitis", 12, 7, 8, 8, 8, 7, 8);

            mok1.Informacija();
            mok2.Informacija();
            mok3.Informacija();
            Console.WriteLine();
            mok1.MoksluPabaiga();
            mok2.MoksluPabaiga();
            mok3.MoksluPabaiga();
            Console.WriteLine();
            Console.WriteLine($"Mokinio {mok1.Vardas} mažiausias pažymys yra {mok1.Pazymiai.Min()}, o didžiausias - {mok1.Pazymiai.Max()}");
            Console.WriteLine($"Mokinio {mok2.Vardas} mažiausias pažymys yra {mok2.Pazymiai.Min()}, o didžiausias - {mok2.Pazymiai.Max()}");
            Console.WriteLine($"Mokinio {mok3.Vardas} mažiausias pažymys yra {mok3.Pazymiai.Min()}, o didžiausias - {mok3.Pazymiai.Max()}");
            Console.WriteLine();
            Console.WriteLine($"Mokinys {mok1.Vardas} turi {Kiekis(mok1)} pažymius didesnius už 4 iš {mok1.Pazymiai.Count()} pažymių.");
            Console.WriteLine($"Mokinys {mok2.Vardas} turi {Kiekis(mok2)} pažymius didesnius už 4 iš {mok2.Pazymiai.Count()} pažymių.");
            Console.WriteLine($"Mokinys {mok3.Vardas} turi {Kiekis(mok3)} pažymius didesnius už 4 iš {mok3.Pazymiai.Count()} pažymių.");

        }

        public static int Kiekis(Mokinys mok)
        {
            int kiek = 0;
            foreach (int item in mok.Pazymiai)
            {
                if (item > 4)
                    kiek++;
            }
            return kiek;
        }
    }
}
