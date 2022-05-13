/*
 * 3 paskaita pdf
 * 80 skaidre
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine("Įveskite skaičių");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }
            Sudetis(skaiciai);
        }

        public static void Sudetis(int[] x)
        {
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma += x[i];
            }
            Console.WriteLine("Masyvo suma " + suma);
            Console.WriteLine("Masyvo suma " + x.Sum());
        }
    }
}
