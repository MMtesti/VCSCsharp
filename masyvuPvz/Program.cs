using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masyvuPvz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 8, 7, 15, 9, -50 };
            foreach (int item in masyvas) // item yra masyvo elementai, galima uzsivadinti kaip notim
            {
                if (item % 2 == 0)
                {
                    Console.Write($"{item} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int item in masyvas)
            {
                if (item % 2 != 0)
                {
                    Console.Write($"{item},");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            char[] simboliai = new char[3];
            simboliai[0] = 'M';
            simboliai[1] = '&';
            simboliai[2] = '5';
            foreach (char simb in simboliai) // item uzvadintas simb
            { 
                Console.WriteLine(simb);
            }
        }
    }
}
