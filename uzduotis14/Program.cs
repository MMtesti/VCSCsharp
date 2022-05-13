/*
2 paskaita pdf
88 skaidre
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis14
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;  // reikia suma prisilyginti 0, nes suma neturi pradzioje reiksmes
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaičių nuo 1 iki 100 suma lygi " + suma);

            Console.WriteLine();
            suma = 0; // butina nusinulinti suma
           
            for (int i = 20; i <= 40; i++)// arba i+= 2 padaryti, tada nasesnis apskaiciavimas
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
                
            }
            Console.WriteLine("Suma:" + suma);

            suma = 0; // butina nusinulinti suma

            for (int i = 30; i <= 60; i++) // arba sutrumpinimui i = 31; i <= 59; i += 2 . ANuliuojasi tokiu uzrasu if salyga
            {
                if (i % 2 != 0)
                    {
                    suma += i;
                    }
            }
            Console.WriteLine("Suma:" + suma);
            Console.WriteLine();

            suma = 0; // butina nusinulinti suma
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    {
                    suma +=i;
                    }
            }
            Console.WriteLine("Suma:" + suma);
            Console.WriteLine();

            suma = 0; // butina nusinulinti suma
            for (int i = 999; i > 0; i--) // (int i = 1; i <=999; i++) galima ir taip
            {
                if (i % 3 == 0|| i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma: " + suma);



        }
    }
}
