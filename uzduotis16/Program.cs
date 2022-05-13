
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis16
{
    class Program
    {
        static void Main(string[] args)
        {

            //  3 paskaitos pdf. 26 skaidre


            int[] pazymiai = new int[5]; // indeksai velgi nuo 0 prasideda  0 1 2 3 4 siuo atveju

            pazymiai[0] = 8;
            pazymiai[1] = 6;
            pazymiai[2] = 5;
            pazymiai[3] = 7;
            pazymiai[4] = 6;

            string[] marke = { "Opel", "Ford", "Fiat" };

            // 29 skaidre is 3 paskaitos pdf.

            Console.WriteLine(marke.Length);
            Console.WriteLine(marke.First());
            Console.WriteLine(marke.Last());
            Console.WriteLine(marke[marke.Length - 1]);
            Console.WriteLine();
            Console.WriteLine(pazymiai.First());
            Console.WriteLine(pazymiai.Last());
            Console.WriteLine(pazymiai[pazymiai.Length - 1]);

        }
    }
}
