using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIsvedimoBudai
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Jonas";
            int amzius = 18;

            Console.WriteLine("Studento vardas yra " + vardas + ", o jam yra " + amzius + " metų.");
            Console.WriteLine("Studento vardas yra {0}, o jam yra {1} metų.", vardas, amzius);
            Console.WriteLine($"Studento vardas yra {vardas}, o jam yra {amzius} metų.");

            string marke = "Porche";
            string modelis = "911";
            string gamybos_metai = "1970";
            int rida = 15000;

            Console.Write("Automobilis " + marke + " " + modelis);
            Console.Write(" (" + gamybos_metai + " m.)");
            Console.WriteLine(" yra nuvažiavęs " + rida + " km.");


            
        }
    }
}
