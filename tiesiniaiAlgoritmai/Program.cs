using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiesiniaiAlgoritmai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] graza = { 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Įveskite grąžą.");
            int g = Convert.ToInt32(Console.ReadLine());
            int b100, b50, b20, b10, m1, m2;
            if (g != 0)
            {
                Console.WriteLine("Jūsų grąža yra " + g + ", reikės atiduoti: ");
                if (g % 100 == 0)
                {
                    b100 = g / 100;
                    Console.WriteLine("Jums turiu atiduoti {0} po 100 nominalo banknotą", b100);
                }


            }
        }
    }
}
