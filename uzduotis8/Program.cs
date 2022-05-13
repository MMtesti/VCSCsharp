/*
2 paskaita pdf
48 skaidre

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            if (pirmas % 2 ==0)
            {
                Console.WriteLine("Jūsų skaičius yra " + pirmas + " ir pakeltas penktuoju laipsiu yra lygus " + Math.Pow(pirmas, 5));
            }
            if (pirmas % 4 != 0)
            {
                Console.WriteLine("Įveskite antrą skaičių");
                int antras = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sugalvotų skaičių suma " + (pirmas + antras) + ", o sandauga " + (pirmas * antras));
            }
        }
    }
}
