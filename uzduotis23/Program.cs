using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis23
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 paskaita, 72 skaidre
            int z = 36, w = 3;
            Console.WriteLine("Pirmas skaicius " + z);
            Console.WriteLine("Antras skaicius " + w);
            Suma(z, w);
            Skirtumas(z, w);
            Daugyba(z, w);
            Dalyba(z, w);

        }

        public static void Suma(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public static void Skirtumas(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public static void Daugyba(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public static void Dalyba(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {Math.Round((double)x / y), 2}");
        }

    }
}
