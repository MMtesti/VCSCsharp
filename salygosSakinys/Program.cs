using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salygosSakinys
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 uzduotis
            /*int a, b, suma;
            
            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            suma = a + b;
            if ( suma == 5)
            {
                Console.WriteLine("Įvestų skaičių a = " + a + " ir b = " + b + " suma lygi 5");
            }
            else
            {
                Console.WriteLine("Įvestų skaičių a = " + a + " ir b = " + b + " suma nelygi 5");
            }
            Console.WriteLine();

            // 2 uzduotis

            int keturzenklis, pirmas;
            Console.WriteLine("Įveskite keturženklį skaičių");
            keturzenklis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (keturzenklis < 1000 || keturzenklis > 9999)
            {
                Console.WriteLine("Neteisingai įvestas skaičius. Skaičius turi būti intervale [1000 - 9999]");
                Console.WriteLine("Veskite dar kartą");
                keturzenklis = Convert.ToInt32(Console.ReadLine());
            }
            pirmas = keturzenklis / 1000;
            if (pirmas % 2 == 0)
            {
                Console.WriteLine("Įvesto keturženklio skaičiaus " + keturzenklis + " pirmas skaitmuo yra lyginis");
            }
            else
            {
                Console.WriteLine("Įvesto keturženklio skaičiaus " + keturzenklis + " pirmas skaitmuo yra nelyginis");
            }
            Console.WriteLine();
            Console.WriteLine();

            // 3. uzduotis

            int dvizenklis, antras;
            Console.WriteLine("Įveskite dviženklį skaičių");
            dvizenklis = Convert.ToInt32(Console.ReadLine());
            pirmas = dvizenklis / 10;
            antras = dvizenklis % 10;
            suma = pirmas + antras;
            Console.WriteLine();
            if (suma % 3 == 0)
            {
                Console.WriteLine("Įvesto dviženklio skaičiaus " + dvizenklis + " suma dalinasi iš 3 be liekanos");
            }
            else
            {
                Console.WriteLine("Įvesto dviženklio skaičiaus " + dvizenklis + " suma dalinasi iš 3 su liekana");
            }
            // 4. uzduotis
            int tr1, tr2;
            int suma1, suma2;
            int trpirmas1, trantras1, trtrecias1, trpirmas2, trantras2, trtrecias2;
            Console.WriteLine("Įveskite pirmą triženklį skaičių");
            tr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą triženklį skaičių");
            tr2 = Convert.ToInt32(Console.ReadLine());
            trpirmas1 = tr1 % 10;
            trantras1 = (tr1/ 10) % 10;
            trtrecias1 = tr1 / 100;
            suma1 = trpirmas1 + trantras1 + trtrecias1;
            Console.WriteLine("Pirmo triženklio skaičiaus skaičiai " + trpirmas1 + ", " + trantras1 + ", " + trtrecias1 + " ir skaitmenų suma " + suma1);
            trpirmas2 = tr2 % 10;
            trantras2 = (tr2 / 10) % 10;
            trtrecias2 = tr2 / 100;
            suma2 = trpirmas2 + trantras2 + trtrecias2;
            Console.WriteLine("Antro triženklio skaičiaus skaičiai " + trpirmas2 + ", " + trantras2 + ", " + trtrecias2 + " ir skaitmenų suma " + suma2);
            if (suma1 == suma2)
            {
                Console.WriteLine("Įvestų triženklių skaičių " + tr1 + " ir " + tr2 + " skaitmenų sumos yra lygios " );
            }
            else
            {
                Console.WriteLine("Įvestų triženklių skaičių " + tr1 + " ir " + tr2 + " skaitmenų sumos nėra lygios ");
            }
           
            // 5. uzduotis
            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 10)
            {
                a *= 2;
                Console.WriteLine(a);
            }
            

            // 6. uzduotis
            Console.WriteLine("Įveskite metus >= 1896 m.");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            //pirmos žaidynės 1896 m., olimpiniu zaidyniu numeris n = 1. Vyksta kas 4 metai.
            if ((m - 1896) % 4 == 0)
            {
                n = (m - 1896)/4 + n ;
                Console.WriteLine("Metai olimpiniai, žaidynių eilės numeris yra " + n);
            }
            else
            {
                Console.WriteLine("Metai neolimpiniai");
            }
            Console.WriteLine()
             
            // 7. uzduotis
            Console.WriteLine("Įveskite skaičių");
            int c = Convert.ToInt32(Console.ReadLine());
            if ( c >= 0)
            {
                if (c % 2 == 0 && c != 0)
                {
                    Console.WriteLine("Įvestas skaičius yra lyginis");
                }
                else if (c % 2 != 0)
                {
                    Console.WriteLine("Įvestas skaičius yra nelyginis");
                }
                else if (c == 0)
                {
                    Console.WriteLine("Įvestas skaičius yra nulis");
                }
            }
            else
            {
                Console.WriteLine("Pasirinktas skaičius neigiamas");
            }
            */

            //10. uzduotis

            int a, b, c;
            
            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių c.");
            c = Convert.ToInt32(Console.ReadLine());
            int pirmas = 0, antras = 0, trecias = 0;
            
            if ( a < b && a < c && b < c)
            {
                pirmas = a;
                antras = b;
                trecias = c;
            }
            else if (a < b &&  a < c && c < b)
            {
                pirmas = a;
                antras = c;
                trecias = b;
            }
            else if (b < a && b < c && a < c )
            {
                pirmas = b;
                antras = a;
                trecias = c;
            }
            else if (b < c && b < a && c < a)
            {
                pirmas = b;
                antras = c;
                trecias = a;
            }
            else if ( c < a && c < b && a < b)
            {
                pirmas = c;
                antras = a;
                trecias = b;
            }
            else
            {
                pirmas = c;
                antras = b;
                trecias = a;
            }
            Console.WriteLine();
            // 11. uzduotis
            Console.WriteLine("Įvesti skaičiai didėjančia tvarka: " + pirmas + " " + antras + " " + trecias);

            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių c.");
            c = Convert.ToInt32(Console.ReadLine());
            if ( a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine(" Tarp šių skaičių " + a + ", " + b + ", " + c + "yra neigiamų");
            }
            else
            {
                Console.WriteLine("Tarp šių skaičių nėra neigiamų");
            }
            Console.WriteLine();

            // 12. uzduotis
            int trizenklis;
            Console.WriteLine("Įveskite triženklį skaičių.");
            trizenklis = Convert.ToInt32(Console.ReadLine());
            pirmas = trizenklis / 100;
            antras = (trizenklis / 10) % 10;
            trecias = trizenklis % 10;
            Console.WriteLine();
            if (pirmas > 5 || antras > 5 || trecias > 5)
            {
                Console.WriteLine("Įvestas triženklis skaičius " + trizenklis + " turi skaitmenų didesnių už 5.");
            }
            else
            {
                Console.WriteLine("Įvestas triženklis skaičius " + trizenklis + " neturi skaitmenų didesnių už 5.");
            }
            Console.WriteLine();
            string bb = "845";
            char pirmas1 = bb[0];
            char antras1 = bb[1];
            char trecias1 = bb[2];
            if (pirmas1 > 53 || antras1 > 53 || trecias1 > 53) // 5 = 53 pagal ASCII lentele
            { 
                Console.WriteLine("yra");
            }
            else 
            {
                Console.WriteLine("nera");
            }
            if (pirmas1 > '5' || antras1 > '5' || trecias1 > '5') // arba taip nurodyti
            {
                Console.WriteLine("yra");
            }
            else
            {
                Console.WriteLine("nera");
            }
            Console.WriteLine();
            // 13. uzduotis
            //trikampį galima sudaryti tik tada, kai bet kurių dviejų kraštinių suma yra  didesnė už trečiąją.
            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių c.");
            c = Convert.ToInt32(Console.ReadLine());
            if ( (a + b) > c && ( a + c > b && (b + c) > a))
            {
                Console.WriteLine("Trikampį sudaryti galima");
            }
            else
            {
                Console.WriteLine("Trikampį sudaryti negalima");
            }
            Console.WriteLine();
            // 14. uzduotis
            Console.WriteLine("Įveskite skaičių a.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių b.");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių c.");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Galima sudaryti lygiakraštį trikampį");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Galima sudaryti lygiašonį trikampį");
            }
            else if ((a + b) > c && (a + c) > b && (b + c) > a)
            {

                Console.WriteLine("Galima sudaryti įvairiakraštį trikampį");
            }
            else
            {
                Console.WriteLine("Trikampį sudaryti negalima");
            }
        }
    }
}
