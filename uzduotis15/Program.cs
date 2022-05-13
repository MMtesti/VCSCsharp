/*
 * Milda Mykolaitiens 2022 04 07
 * 2 paskaita pdf
 * 96 skaidre
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite bet kokį teigiamą skaičių");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius > 0)
            {
                Console.WriteLine(skaicius--);
            }
            Console.WriteLine();

            Console.WriteLine("Įveskite bet kokį neigiamą skaičių");
            skaicius = Convert.ToInt32(Console.ReadLine());
            while (skaicius <= 0)
            {
                Console.Write("{0} ", skaicius++);
            }

            Console.WriteLine();
            Console.WriteLine();

            int pirmas, antras, suma, skirtumas, daugyba;
            double dalyba;
            bool nori = true;
            Console.WriteLine("Ar norite atlikti skaičiavimus?\n True - Taip/ False - ne");
            nori = Convert.ToBoolean(Console.ReadLine());
            while (nori)
            {
                Console.WriteLine("Įveskite pirmąjį skaičių");  // reikia naudoti try catch 
                pirmas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Įveskite antrąjį skaičių"); // reikia naudoti try catch 
                antras = Convert.ToInt32(Console.ReadLine());

                suma = pirmas + antras;
                skirtumas = pirmas - antras;
                daugyba = pirmas * antras;
                dalyba = (double)pirmas / antras;
                dalyba = Math.Round(dalyba, 2);

                Console.WriteLine("Įvestų skaičių suma: {0} + {1} = {2}", pirmas, antras, suma);
                Console.WriteLine("Įvestų skaičių skirtumas: {0} - {1} = {2}", pirmas, antras, skirtumas);
                Console.WriteLine("Įvestų skaičių daugyba: {0} * {1} = {2}", pirmas, antras, daugyba);
                Console.WriteLine("Įvestų skaičių dalyba: {0} / {1} = {2}", pirmas, antras, dalyba);
                Console.WriteLine("Ar norite tęsti skaičiavimą?");
                nori = Convert.ToBoolean(Console.ReadLine()); // reikia naudoti try catch 
            }
            Console.WriteLine();
            Console.WriteLine("Programos pabaiga");
        }
    }
}
