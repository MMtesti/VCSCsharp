using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2pdf99ND3
{
    class Program
    {
        static void Main(string[] args)
        {
            // namu darbai 99 skaidre , 1 ND

            int kiekis = 0; // 1 variantas
            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                    kiekis++;
                }
            }
            Console.WriteLine("{0} skaičiai dalinasi iš 16 intervale [0 - 10000)", kiekis);
            Console.WriteLine();

            kiekis = 0;

            for (int i = 0; i < 1000; i += 16) // 2 variantas
            {
                kiekis++;
            }
            Console.WriteLine("{0} skaičiai dalinasi iš 16 intervale [0 - 10000)", kiekis);
            Console.WriteLine();

            // namu darbai 99 skaidre, 2  ND
            
            double skaicius, atsakymas;
            int laipsnis = 2;
            Console.WriteLine("Programa kels skaičių laipsniu, kaskart laipsnį didindama vienetu, kol atsakymas neviršys 1500.");
            Console.WriteLine("Įveskite teigiamą skaičių > 1.");
            skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Skaičius = " + skaicius + " , Laipsnis = " + laipsnis);

            atsakymas = Math.Pow(skaicius, laipsnis);

            if (skaicius > 1)
            {
                while (atsakymas <= 1500)
                {
                    atsakymas = Math.Pow(skaicius, laipsnis);
                    if (atsakymas <= 1500)
                    {
                        Console.WriteLine(skaicius + " pakeltas " + laipsnis + " = " + atsakymas);
                    }
                    else
                    {
                        Console.WriteLine(skaicius + " pakeltas " + laipsnis + " laipsniu > uz 1500");
                        break;
                    }
                    laipsnis++;

                }
            }
            else
            {
                Console.WriteLine("Įvestas skaičius nėra didesnis už 1.");
            }

        }
    }
}
