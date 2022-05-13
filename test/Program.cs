using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = {3, 2, 4, 8, 10, 12};
            foreach (int item in masyvas)
            {
               Console.Write($"{item} ");
            }
                Console.WriteLine();

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write($"{masyvas[i]} ");
            }
            Console.WriteLine();

            int suma = 0;
            for (int i = 20; i<= 40; i++)
            {
                if ( i% 2 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("atsakymas " + suma);

            string pirmas = "a";
            string antras = "b";

            Console.WriteLine($"{pirmas} + {antras} = {pirmas + antras}");


        
        
        



        }
    }
}
