/*
 * 2 paskaita pdf
 * 86 skaidre
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = 0; i <= 15; i += 2)
            {
                Console.Write(i + " ");
            
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 20; i += 3)
            {
                Console.Write($"[{i}]");
            }

            Console.WriteLine();
            

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 ==0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine(); 

            // arba taip paprastesnis

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
