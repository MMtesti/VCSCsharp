using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zodziai = new List<string>();
            zodziai.Add("laumzirgis");
            zodziai.Add("muse"); 
            zodziai.Add("ciuozikas");
            zodziai.Add("uodas");
            zodziai.Add("kamane");

            Console.WriteLine("Įveskite");
            string ilg = zodziai.First(); // arba zodziai[0];
            string trum = zodziai.First();
            int max = zodziai.First().Length;
            int min = zodziai.First().Length;
            foreach ( string item in zodziai)
            {
               if (item.Length > max)
                {
                    max = item.Length;
                    ilg = item;
                }

               if (item.Length < min)
                {
                    min = item.Length;
                    trum = item;
                }
            }
            Console.WriteLine("Sąrašo ilgiausias žodis " + ilg + ", kuris sudarytas iš " + ilg.Length + " raidžių.");
            Console.WriteLine("Sąrašo trumpiausias žodis " + trum + ", kuris sudarytas iš " + trum.Length + " raidžių.");


        }
    }
}
