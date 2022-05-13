using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Įvesti skaičiai {a} ir {b}");
            Console.WriteLine();
            Console.WriteLine("Kokį veiksmą norite atlikti su skaičiais: 1 sudėtis; 2 atimtis; 3 skaičių sumos kėlimas 4 tu laipsniu; 4 skaičių sumos" +
                " kvadratinė šaknis");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (pasirinkimas)
            {
                case 1:
                    Sudeti(a, b);
                    break;
                case 2:
                    Atimti(a, b);
                    break;
                case 3:
                    Console.WriteLine("Įvestų skaičių sumos 4 tas laipsnis yra " + KelimasLaipsniu(a, b));
                    break;
                case 4:
                    Console.WriteLine("Įvestų skaičių sumos 4 tas laipsnis yra " + Saknis(a, b));
                    break;
                default:
                    Console.WriteLine("Tokio atsakymo nėra");
                    break;

            }
            
        }
        public static void Sudeti(int x, int y)
        {
            Console.WriteLine($"Pasirinktų skaičių suma {x} + {y} = {x + y}");
        }
        public static void Atimti(int x, int y)
        {
            Console.WriteLine($"Pasirinktų skaičių skirtumas {x} - {y} = {x - y}");
        }
        public static double KelimasLaipsniu(int x, int y)
        {
            return Math.Pow(x + y, 4);// jei norim kad buti float tipo, padarome metoda float ir pries Math parasyti float
        }
        public static double Saknis(int x, int y)
        {
            return Math.Sqrt(x + y);
        }
    }
}
