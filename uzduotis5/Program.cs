using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas {vardas}, o amžius {amzius}");

            Console.WriteLine("Įveskite bet kokį simbolį: ");
            string simbolis = Console.ReadLine(); // geriau daryti naudojant char, tada reikia konvertuoti
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);

            Console.WriteLine("Įveskite bet kokį simbolį: ");
            char simbolis1 = Convert.ToChar(Console.Read());// su konvertavimu i char

            Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", simbolis1);
            Console.WriteLine("{0}{0}{0}", simbolis1);
            Console.WriteLine("{0}{0}{0}", simbolis1);

            
            Console.WriteLine("Įveskite bet kokį skaičių: ");

            // try-catch funkcija, kad patikrinti teisingai ivesta atsakyma, pvz praso skaiciaus, iveda raide.

            double skaicius = 0;
            try
            {
                skaicius = Convert.ToDouble(Console.ReadLine()); //ReadLine naudojamas tik su string, todel reikia konvertuoti i double
            }

            catch
            {
                Console.WriteLine("Įvedėte neteisingą simbolį! Veskite skaičių.");
            }
            double kvadratas = Math.Pow(skaicius, 2);
            Console.WriteLine($"Jūsų skaičiaus kvadratas -  " + kvadratas);
            Console.WriteLine();

        

            Console.WriteLine("Įveskite pirmą skaičių: ");
            int pirmas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių: ");
            int antras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečią skaičių: ");
            int trecias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} + {2} = {3}", pirmas, antras, trecias, (pirmas + antras + trecias));
            Console.WriteLine("{0} - {1} - {2} = {3}", pirmas, antras, trecias, (pirmas - antras - trecias));
            Console.WriteLine("{0} * {1} * {2} = {3}", pirmas, antras, trecias, (pirmas * antras * trecias));

            double dalmuo = (double)pirmas / antras / trecias;
            dalmuo = Math.Round(dalmuo, 2);
            Console.WriteLine("{0} / {1} / {2} = {3}", pirmas, antras, trecias, dalmuo);
        }
    }
}
