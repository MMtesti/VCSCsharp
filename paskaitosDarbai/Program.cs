
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paskaitosDarbai
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            * 3 paskaita, 9 skaidre
            */
            int statinis, statinis2;
            double izambineKv, izambine;
            Console.WriteLine("Parašykite trikampio pirmo statinio ilgį");
            statinis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite trikampio antro statinio ilgį");
            statinis2 = Convert.ToInt32(Console.ReadLine());

            izambineKv = Math.Pow(statinis, 2) + Math.Pow(statinis2, 2);
            izambine = Math.Sqrt(izambineKv);
            izambine = Math.Round(izambine, 2);
            Console.WriteLine("Įžambinė lygi " + izambine);

            

        }
    }
}
