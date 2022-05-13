using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Milda";
            
            

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Labas " + vardas);
            Console.WriteLine($"Labas {vardas}");
            Console.WriteLine("Labas {0}", vardas);

            int amzius = 18;
            Console.WriteLine($"Įvestas amžius: {amzius}");
            Console.WriteLine("Įvestas amžius: " + amzius);
            Console.WriteLine("Įvestas amžius: {0}", amzius);

            string skaicius = "25";
            Console.WriteLine("{0}{1}{2}{3}{4}", skaicius, skaicius, skaicius, skaicius, skaicius);
            Console.WriteLine("{0}{0}{0}{0}{0}", skaicius); // galima ir taip
            Console.WriteLine($"{skaicius}{skaicius}{skaicius}{skaicius}{skaicius}");
            Console.WriteLine(skaicius + skaicius + skaicius + skaicius + skaicius);
            Console.WriteLine(string.Concat(Enumerable.Repeat(skaicius, 5)));// galima ir taip


            Console.WriteLine("{0} {1} {2} {3} {4}", skaicius, skaicius, skaicius, skaicius, skaicius);
            Console.WriteLine("{0} {0} {0} {0} {0}", skaicius); // galima ir taip
            Console.WriteLine(skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " " + skaicius);
            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius} {skaicius}");

            string skaicius1 = "25 ";
            Console.WriteLine(string.Concat(Enumerable.Repeat(skaicius1, 5))); // galima ir taip

            /*
            Galima naudoti repeat 
            sk2 = "1 ";
            int a = 9;
            Console.WriteLine(string.Concat(Enumerable.Repeat(a, 9))); // Galima ir taip
            Console.WriteLine(string.Concat(Enumerable.Repeat(sk2, 5)));
            */

            string sk2 = "1 ";
            int a = 9;
            Console.WriteLine(string.Concat(Enumerable.Repeat(a, 9)));
            Console.WriteLine(string.Concat(Enumerable.Repeat(sk2, 5)));

            
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", skaicius, skaicius, skaicius, skaicius, skaicius,
                skaicius, skaicius, skaicius, skaicius); // perkelti i kita eilute galima spaudziant enter


        }
    }
}
