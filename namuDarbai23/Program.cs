/*
 * 2 paskaita pdf 98 ir 99 skaidres
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namuDarbai23
{
    class Program
    {
        static void Main(string[] args)
        {

            // Namu darbai, 98 skaidre

            Console.WriteLine("1 Užduotis 'Kepyka'");
            Console.WriteLine();
            int darboValandos = 8; // darbo valandu per diena, vnt
            int kiekis; // kiek darbuotojas iskepa per 1 val, vnt
            int darbuotojai; //kiek darbuotoju turi kepykla, vnt
            int uzsakymai; // kiek ta diena turi iskepti kepalu, vnt
            double savikaina, pardavimoKaina, pelnas; // kepalo savikaina / pardavimo kaina, pelnas
            Console.WriteLine();

            Console.WriteLine("Įveskite, kiek darbuotojas gali iškepti kepalų per 1 valandą?");
            kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite, kiek darbuotojų dirba kepykloje");
            darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite, koks yra kepalų užsakymo kiekis");
            uzsakymai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite, kokia duonos kepalo savikaina");
            savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite, kokia duonos kepalo pardavimo kaina");
            pardavimoKaina = Convert.ToDouble(Console.ReadLine());

            while (pardavimoKaina <= savikaina)
            {
                Console.WriteLine("Neteisingai įvedėte pardavimo kainą. Ji turi būti aukštesnė už savikainą");
                Console.WriteLine("Įveskite, kokia duonos kepalo pardavimo kaina");
                pardavimoKaina = Convert.ToDouble(Console.ReadLine());
            }

            int visasKiekis = (darboValandos * kiekis * darbuotojai); // per 1 diena gali iskepti kepykla
            Console.WriteLine("Kepykla iškepa " + visasKiekis + " kepalų per dieną");

            Console.WriteLine();

            if (visasKiekis >= uzsakymai)
            {
                Console.WriteLine("Kepykla spėja įvykdyti tos dienos užsakymus - " + uzsakymai + " vnt. kepalų");
                pelnas = (visasKiekis * pardavimoKaina) - (uzsakymai * savikaina);
                Console.WriteLine("Kepykla per dieną uždirbs " + pelnas + " Eur pelno, kai iškepa visą užsakymų kiekį");
            }
            else
            {
                Console.WriteLine("Kepykla nespėja įvykdyti visų užsakymų. Nespėja iškepti " + (uzsakymai - visasKiekis) + " vnt kepalų");
                pelnas = (visasKiekis * pardavimoKaina) - (visasKiekis * savikaina);
                Console.WriteLine("Kepykla per dieną uždirbs " + pelnas + " Eur pelno, kai nespėja iškepti viso užsakymo kiekio. ");
                Console.WriteLine();
            }

        }
    }    
}
