/*
 * Papoildomi uzdaviniai - Skaitmenu Uzdaviniai pdf
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaitmenuUzdaviniai
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Parašykite programą, kuri rastų dviženklio skaičiaus skaitmenų sumą

            int dvizenklis, pirmas, trizenklis, keturzenklis, pora;
            int antras, paskutinis, pora2, trecias, n, x;
            Console.WriteLine("Įveskite dviženklį skaičių");
            dvizenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            pirmas = dvizenklis / 10;
            antras = dvizenklis % 10;

            Console.WriteLine("Jūsų įvesto dviženklio skaičiaus " + dvizenklis + " skaitmenų suma " + pirmas + " + " + antras + " = "  + ( pirmas + antras) );
            Console.WriteLine();
            // 2. Parašykite programą, kuri rastų triženklio skaičiaus skaitmenų sumą

            
            Console.WriteLine("Įveskite triženklį skaičių");
            trizenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            paskutinis = trizenklis % 10;
            antras = (trizenklis / 10) % 10; // buvau ((trizenklis - paskutinis) / 10) % 10
            pirmas = trizenklis / 100; // buvau sugalvojusi (trizenklis - (trizenklis % 100)) / 100
            Console.WriteLine();
            Console.WriteLine("Pateikto triženklio skaičiaus " + trizenklis + " skaitmenų " + pirmas + ", " + antras + ", " + paskutinis + " suma yra lygi " + ( pirmas + antras + paskutinis));
            Console.WriteLine();
            // 3. Parašykite programą, kuri sukeistų vietomis dviženklio skaičiaus skaitmenis
            
            Console.WriteLine("Įveskite dviženklį skaičių");
            dvizenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            pirmas = dvizenklis / 10;
            antras = dvizenklis % 10;
            Console.WriteLine();
            Console.WriteLine( "Įvestas dviženklis skaičius - " + dvizenklis + ", o skaitmenis sukeitus vietomis gauname skaičių " + antras + pirmas + " ." );
            Console.WriteLine();

            // 4. Parašykite programą, kuri sukeistų vietomis pirmą ir paskutinį triženklio skaičiaus skaitmenis.
            Console.WriteLine("Įveskite triženklį skaičių");
            trizenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            paskutinis = trizenklis % 10;
            antras = (trizenklis / 10) % 10; // buvau ((trizenklis - paskutinis) / 10) % 10
            pirmas = trizenklis  / 100; // buvau sugalvojusi (trizenklis - (trizenklis % 100)) / 100
            Console.WriteLine();
            Console.WriteLine("Įvestas triženklis skaičius " + trizenklis + ", o sukeitus vietomis pirmą ir paskutinį skaitmenį gauname " + paskutinis + antras + pirmas + " .");
            Console.WriteLine();

            // 5. Parašykite programą, kuri sukeistų vietomis pirmą keturženklio skaičiaus skaitmenų porą su paskutine.
            Console.WriteLine("Įveskite keturženklį skaičių");
            keturzenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            pora = keturzenklis / 100;
            pora2 = keturzenklis % 100;
            Console.WriteLine();
            Console.WriteLine("Įvestas keturženklis skaičius " + keturzenklis + ", o sukeitus vietomis skaitmenų poras gauname " + pora2 + pora + " .");
            Console.WriteLine();

            // 6. Parašykite programą, kuri rastų keturženklio skaičiaus skaitmenų sumą.

            Console.WriteLine("Įveskite keturženklį skaičių");
            keturzenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            pirmas = keturzenklis / 1000;
            antras = (keturzenklis / 100) % 10;
            trecias = (keturzenklis/10) % 10;
            paskutinis = keturzenklis % 10;
            Console.WriteLine();
            Console.WriteLine("Įvestas keturženklis skaičius, kurio skamtmenų " + pirmas + ", " + antras + ", " + trecias + ", " + paskutinis + 
                " suma lygi " + ( pirmas + antras + trecias + paskutinis) +  ".");
            Console.WriteLine();

            /*
             7. Nubrauktas triženklio skaičiaus x antrasis skaitmuo. Prie likusio dviženklio skaičiaus iš kairės 
            prirašius nubrauktąjį skaitmenį, gautas skaičius n. (10 < n ≤ 999, be to, skaičiaus n dešimčių
            skaitmuo nelygus nuliui).Parašykite programą, kuri apskaičiuotų, kokia buvo x reikšmė, kai n reikšmė įvedama klaviatūra.
            */

            Console.WriteLine("Įveskite triženklį sveiką sakičių, kuris patenka tarp [ 110 - 999] skaičių");
            n = 0;
            try

            {
                n = Convert.ToInt32(Console.ReadLine()); // patikrinu, kad ivestu skaicius
            }
            catch
            {
                Console.WriteLine("Įvedėte neteisingą simbolį! Veskite skaičių.");
            }
            Console.WriteLine();
            while (n < 110 || n > 999)
            {
                Console.WriteLine("Blogai įvestas skaičius. Jis turi būti > 110 ir <= 999");
                Console.WriteLine("Bandykite dar kartą");
                n = 0;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine()); // patikrinu, kad ivestu skaicius
                }
                catch
                {
                    Console.WriteLine("Įvedėte neteisingą simbolį! Veskite skaičių.");
                }
            }
            Console.WriteLine();

            antras = (n / 10) % 10;

            while (antras == 0)
            {
                Console.WriteLine("Neteisingas antras skaitmuo, jis turi būti > 0.");
                Console.WriteLine("Veskite dar kartą");
                n = Convert.ToInt32(Console.ReadLine());
                antras = (n / 10) % 10;
            }

            pirmas = n / 100;
            trecias = n % 10;

            Console.WriteLine();
            
            Console.WriteLine("X skaičius yra lygus " + antras + pirmas + trecias);





        }
    }
}
