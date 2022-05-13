
/*
 * 2 paskaita pdf 
 * 15 skaidre
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis4
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 9;
            int dvizenklis = 64;


            Console.WriteLine("{0} * 1 = {1}", skaicius, (skaicius * 1));
            Console.WriteLine("{0} * 2 = {1}", skaicius, (skaicius * 2));
            Console.WriteLine("{0} * 3 = {1}", skaicius, (skaicius * 3));
            Console.WriteLine("{0} * 4 = {1}", skaicius, (skaicius * 4));
            Console.WriteLine("{0} * 5 = {1}", skaicius, (skaicius * 5));
            Console.WriteLine("{0} * 6 = {1}", skaicius, (skaicius * 6));
            Console.WriteLine("{0} * 7 = {1}", skaicius, (skaicius * 7));
            Console.WriteLine("{0} * 8 = {1}", skaicius, (skaicius * 8));
            Console.WriteLine("{0} * 9 = {1}", skaicius, (skaicius * 9));
            Console.WriteLine("{0} * 10 = {1}", skaicius, (skaicius * 10));

            Console.WriteLine("Sugalvotas skaičius " + dvizenklis);
            int pirmas = dvizenklis / 10;
            int antras = dvizenklis % 10;

            Console.WriteLine("Sugalvoto dviženklio skaičiaus skaitmenų sandauga lygi {0} * {1} = {2}", pirmas, antras, (pirmas * antras));
            Console.WriteLine();


            // dar vienas būdas naudojant masyvą ištraukti atskirus ksaicius. Tačiau pradžioje ksaičius turi būti string tipo, paskui konvertuoti į int

            string sk = "123456";
            pirmas = Convert.ToInt32(sk[0]);
            antras = Convert.ToInt32(sk[1]);
           
          
        }
    }
}
