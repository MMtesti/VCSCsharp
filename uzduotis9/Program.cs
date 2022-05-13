/*
 *2 paskaita pdf
 *54 skaidre
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite trečią skaičių");
            int trecias = Convert.ToInt32(Console.ReadLine());

            if (pirmas > antras)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą");
            }
            else if (antras > trecias)
            {
                Console.WriteLine("Antras didesnis už trečią.");
            }
            else if (trecias > pirmas)
            {
                Console.WriteLine("Trečias didesnis už pirmą");
            }

            else if ( pirmas == antras)
            {
                Console.WriteLine(" Abu pirmi skaičiai lygūs");
            }

            Console.WriteLine("Įveskite šios dienos temperatūrą.");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Žiauriai šalta");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Šalta");
            }
            else if (temp <30)
            {
                Console.WriteLine("Normali temperatūra");
            }
            else if (temp < 40)
            {
                Console.WriteLine("Karšta");
            }

            else
            {
                Console.WriteLine("Visiškai degina!");
            }

        }

    }
}
