using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            int suma = a + b;
            int skirtumas = a - b;
            int daugyba = a * b;
            double dalmuo = (double) a / b; // double rodo pvz 0,2535; 1,233 ir pan. reiksmiu skaiciu. Jei a ir b butu double, tai dalyba = a/b
            dalmuo = Math.Round(dalmuo, 1); // suapvalinimas iki norimo skaiciaus po kablelio, pvz 1 sk po kablelio.

            Console.WriteLine($"{a} + {b} = {suma}"); // galima ir taip = {a+b}
            Console.WriteLine($"{a} - {b} = {skirtumas}"); // galima ir taip = {a-b}
            Console.WriteLine($"{a} * {b} = {daugyba}"); // galima ir taip = {a*b}
            Console.WriteLine($"{a} / {b} = {dalmuo}"); // galima ir taip = {(double)a+b}
            Console.Write($"{a} / {b} =  ");
            Console.WriteLine(String.Format("{0:0.00}", dalmuo)); // galima naudoti apvalinimo būdą tik išvedimui.
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Pasirinktas skaičius " + suma);
            Console.WriteLine("Skaičiaus kvadratas " + (suma * suma)); // arba
            double kv = Math.Pow(suma, 2); // si funkcija pakelia skaiciu norimu laipsniu
            Console.WriteLine("Skaičiaus kvadratas " + kv);
            Console.WriteLine();
            Console.WriteLine("Skaičiaus kubas " + (Math.Pow(suma, 3)));//pakeliu kubu

            double cc = Math.Sqrt(daugyba); // galima istraukti kvadratine sakni
            Console.WriteLine(cc);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Trijų skaičių {0} * {1} * {2} sandauga yra {3}", a, b, suma, (a * b * suma));









        }
    }
}
