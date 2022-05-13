using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salygosUzdaviniai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 15. uzduotis
            int a, b, c;
            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių c.");
            c = Convert.ToInt32(Console.ReadLine());
            double s = (double)(a + b + c) / 2;
            double A = Math.Round( Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            if (a == b && b == c)
            {
                Console.WriteLine("Galima sudaryti lygiakraštį trikampį");
                Console.WriteLine(" Trikampio plotas yra s = " + A);
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Galima sudaryti lygiašonį trikampį");
                Console.WriteLine(" Trikampio plotas yra s = " + A);
            }
            else if ((a + b) > c && (a + c) > b && (b + c) > a && A != (a + b) / 2 && A != (a + c) / 2 && A != (b + c) / 2) // nepavyko atskirti ivairiakrascio ir stataus
            {

                Console.WriteLine("Galima sudaryti įvairiakraštį trikampį");
                Console.WriteLine(" Trikampio plotas yra s = " + A);
            }
            else if ( A == (a + b)/2 || A == (a + c)/2 || A == ( b + c)/2)
            {
                Console.WriteLine("Galima sudaryti įvairiakraštį ir statųjį trikampį");
                Console.WriteLine(" Trikampio plotas yra s = " + A);
            }
            else
            {
                Console.WriteLine("Trikampį sudaryti negalima");
            }
        }
    }
}
