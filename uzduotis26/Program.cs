/*
 * 3 paskaita pdf
 * 79 skaidre
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis26
{
    class Program
    {
        static void Main(string[] args)
        {
            string dauginti = string.Empty;
            string dalinti = string.Empty;
            Console.WriteLine("Įveskite pirmą skaičių");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kokį veiksmą norite atlikti su skaičiais: dauginti; dalinti");
            string atsakymas = Console.ReadLine();

            if (atsakymas.ToLower().Equals("dauginti"))
                {
                Console.WriteLine($"Pasirinkote daugybą. Daugybos atsakymas  {Daugyba(pirmas, antras)}.");
                }
            else if (atsakymas.ToLower().Equals("dalinti"))
                {
                Console.WriteLine("Pasirinkote dalybą. Dalybos atsakymas " + Dalyba(pirmas, antras));
                }
            else
                {
                Console.WriteLine("Tokio veiksmo nėra");
                }
            
        }
        public static int Daugyba( int x, int y)
        {
            return x * y;
        }
        public static float Dalyba( float x, float y)
        {
            return (float)x / y;
        }
    }
}
