using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandymai
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * 2 paskaita pdf
            * 96 skaidre
            */

            int pirmas, antras, suma, skirtumas, daugyba;
            double dalyba;
            string nori = string.Empty;
            Console.WriteLine("Ar norite atlikti skaičiavimus?\nYes/No");
            nori = Console.ReadLine();

            while (nori.ToLower().Equals("yes"))
            {
                Console.WriteLine("Įveskite pirmąjį skaičių");
                pirmas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Įveskite antrąjį skaičių");
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
                Console.WriteLine("yes - taip, no - ne");
                nori = Console.ReadLine();

                while (nori.ToLower() != "yes" && nori.ToLower() != "no")// leidzia patikrinti, kai ivedamas ne yes ir ne no
                {
                    Console.WriteLine("Įveskite tik yes arba no");
                    nori = Console.ReadLine();
                }
            }
        }
    }
}