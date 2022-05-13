using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 paskaita pdf  59 skaidre
            // 1 uzdavinys

            List<int> skaiciai = new List<int>();
            skaiciai.Add(21);
            skaiciai.Add(10);
            skaiciai.Add(52);
            skaiciai.Add(45);
            skaiciai.Add(20);
            skaiciai.Add(15);
            int min = skaiciai[0];
            foreach (int sk in skaiciai)
            {
                if (sk < min)
                {
                    min = sk;
                }
            }
            Console.WriteLine("Mažiausias skaičius yra " + min);
            int max = skaiciai[0];
            for (int i = 0; i < skaiciai.Count; i++)
            {
                if (skaiciai[i] > max)
                {
                    max = skaiciai[i];
                }
            }
            Console.WriteLine("Didžiausias skaičius yra " + max);
            Console.WriteLine("Vidurkis " + Math.Round(skaiciai.Average(), 2));
            int kiekis = 0, suma = 0;
            for (int i = 0; i < skaiciai.Count; i++)
            {
                if (skaiciai[i] < Math.Round(skaiciai.Average(), 2))
                {
                    kiekis++;
                }
                if (skaiciai[i] % 2 == 0)
                {
                    suma += skaiciai[i];
                }
            }
            Console.WriteLine("{0} skaičiai yra žemesnių už vidurkį {1}", kiekis, Math.Round(skaiciai.Average(), 2));
            Console.WriteLine("Lyginių skaičių suma " + suma);
            Console.WriteLine();
            Console.WriteLine();
            // 2 uzdavinys
            kiekis = 0;
            Console.WriteLine("Kiek duomenų įvesti");
            kiekis = Convert.ToInt32(Console.ReadLine());
            List<int> pazymiai = new List<int>();
            for (int i = 0; i <= kiekis ; i++)
            {
                Console.WriteLine("Įveskite pažymį:");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int paz in pazymiai)
            {
                Console.Write("{0} ", paz);//atspausdinamos visos reiksmes
            }
            Console.WriteLine();
            Console.WriteLine("Mažiausias pažymys " + pazymiai.Min());
            Console.WriteLine("Didžiausias pažymys " + pazymiai.Max());
            Console.WriteLine("Pažymių vidurkis " + Math.Round(pazymiai.Average(), 1));

            Console.WriteLine("papildomos funkcijos"); 

            Console.WriteLine(pazymiai[0]); // atspausdina pasirinkta list reiksme. 0 indeksas
            pazymiai[1] = 8; //esama reiksme pakeisiu i kita reiksme
            Console.WriteLine(pazymiai[1]); // turi atspausdinti nauja reiksme
            pazymiai.Add(7);// papildau lista dar viena reiksme. ji tampa paskutine saraso reiksme;
            pazymiai.Insert(2, 9); // cia yra papildomos reiksmes iterpimas i lista. Insert( var index, var item) bet reikai apsirasyti if salygom i>= 0 && i<list.Count
            foreach (int paz in pazymiai)
            {
                Console.Write("{0} ", paz);
            }
            Console.WriteLine();

            // pazymiai.Clear(); viska isvalo is list'o.
            //pazymiai.RemoveAt(); istrins saraso elementa , kurio indeksas 1
            // pazymiai.Remove(10); istrins pirma elementa sarase su reiksme 10





        }
    }
}
