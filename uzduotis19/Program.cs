using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 paskaita pdf 47 skaidre

            Console.WriteLine("Įveskite penkis pažymius eilutėje atskiriant tarpu:");
            string line = Console.ReadLine();
            string[] pazymiai = line.Split(' ');
            int[] paz = new int[pazymiai.Length];
            for (int i = 0; i <pazymiai.Length; i++)
            {
                paz[i] = Convert.ToInt32(pazymiai[i]);
            }
            int max = paz[0];
            for (int i = 0; i <paz.Length; i++)
            {
                if(paz[i] > max)
                {
                    max = paz[i];
                }
            }

            Console.WriteLine("Didžiausias pažymys yra " + max); // galima naudoti max() funkcija.
            Console.WriteLine();
            Console.WriteLine("Įveskite penkis pažymius eilutėje atskiriant kableliu:");
            string line1 = Console.ReadLine();
            string[] pazymiai1 = line1.Split(',');
            int[] paz1 = new int[pazymiai1.Length];
            for (int i = 0; i < pazymiai1.Length; i++)
            {
                paz1[i] = Convert.ToInt32(pazymiai1[i]);
            }
            int min = paz1[0];
            for (int i = 0; i <paz1.Length; i++)
            {
                if (paz1[i] < min)
                {
                    min = paz1[i];
                }
            }
            Console.WriteLine("Mažiausias pažymys yra " + min); // galima naudoti min() funkcija.
        }
    }
}
