using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uzduotis17
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 paskaita pdf 41 skaidre.
            //1 uzduotis
            int[] temper = {23, 17, 10, 5, 0};
            int min = temper[0];
            Console.WriteLine("Vidutinė temperatūra surasta su funkcija average()" + temper.Average());
            Console.WriteLine("Temperatūrų suma surasta su funkcija sum()" + temper.Sum());
            Console.WriteLine("Mažiausia temperatūra surasta su funkcija min(): " + temper.Min());
            Console.WriteLine("Didžiausia temperatūra surasta su funkcija max(): " + temper.Max());
            foreach (var item in temper) // min
            {
                if (item < min)
                {
                    min = item;
                }   
            }
            Console.WriteLine("Žemiausia temperatūra " + min + ".");
            Console.WriteLine();

            int max = temper[0]; // max
            for (int i = 0; i < temper.Length; i++)
            {
                if (temper[i] > max)
                {
                    max = temper[i];
                }
            }
            Console.WriteLine("Aukščiausia temperatūra " + max + ".");
            Console.WriteLine();

            int suma = 0;
            for (int i = 0; i < temper.Length; i++) // vidurkis
            {
                suma += temper[i];
            }

            double vidurkis = (double)suma / temper.Length;
            vidurkis = Math.Round(vidurkis, 1);
            Console.WriteLine("Temperatūrų vidurkis " + vidurkis + ".");
            Console.WriteLine();

            int kiekis = 0;
            for (int i = 0; i < temper.Length; i++) // temperaturu kiekis mazesnis uz vidurki
            {
                if (temper[i] < vidurkis)
                {
                    kiekis++;
                }
            }
            Console.WriteLine("{0} -ų temperatūrų kiekis mažesnis už vidurkį.", kiekis);
            Console.WriteLine();
            kiekis = 0;
            for (int i = 0; i < temper.Length; i++) // temperaturu kiekis didesnis uz vidurki
            {
                if (temper[i] > vidurkis)
                {
                    kiekis++;
                }
            }
            Console.WriteLine("{0} -ų temperatūrų kiekis didesnis už vidurkį.", kiekis);
            Console.WriteLine();
            Console.WriteLine();

            // 2 uzduotis

            int[] pazymiai = { 10, 9, 5, 8, 2, 8, 10, 3, };
            max = pazymiai[0];
            foreach (int pazym in pazymiai) // geriausias pazymys
            {
                if (pazym > max)
                {
                    max = pazym;
                }
            }
            Console.WriteLine("Geriausias pažymys yra " + max + ".");
            Console.WriteLine();
            kiekis = 0;

            for (int i = 0; i < pazymiai.Length; i++)// kiek gavo desimtukus
            {
                if (pazymiai[i] == 10)
                {
                    kiekis++;
                }
            }
            Console.WriteLine("{0} mokiniai yra gavę dešimtukus.", kiekis);
            Console.WriteLine();
            kiekis = 0;
            foreach (int pazym in pazymiai) // kiek gavo zemiau 4
            {
                if (pazym < 4)
                {
                    kiekis++;
                }
            }
            Console.WriteLine("{0} mokiniai yra gavę neigiamą pažymį ( žemiau nei 4).", kiekis);

            suma = 0;

            for (int i = 0; i < pazymiai.Length; i++) // vidurkis
            {
                suma += pazymiai[i];
            }
            vidurkis = (double)suma / pazymiai.Length;
            vidurkis = Math.Round(vidurkis, 1);
            Console.WriteLine("Studentų pažymių vidurkis yra " + vidurkis);
        }
    }
}
