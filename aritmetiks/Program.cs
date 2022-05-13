using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aritmetiks
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int pirmas = 64 / 10;
            double antras = 64 % 10; // liekanos metodas leidzia suzinoti antra dvizenklio skaiciaus skaiciu.

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, (pirmas * antras) );

            int x = 10;

            x += 5; // vietoj x = x + 5;
            //x -= 5; vietoj   x = x - 5;
            // x *= 5; vietoj sio x = x * 5;
            // x /= 5; vietoj sio x = x / 5;

            Console.WriteLine(x);

            Console.WriteLine();

            int y = 20;

            Console.WriteLine(y++); // isveda sena y reiksme ir padidina reiksme 1 nu
            Console.WriteLine(y);  //  padidinta reiksme isvedama cia

            // Console.WriteLine(y--); isveda sena y reiksme ir sumazina reiksme 1 nu
            // Console.WriteLine(y);  pamazinta reiksme isvedama cia

            //Console.WriteLine(++y); padidina vienu vienetu ir isveda nauja reiksme
            //Console.WriteLine(--y);  pamazina vienu vienetu ir isveda nauja reiksme



            double dalmuo1 = (double)6 / 7; // 6/7 = 0,8571428571428571
            dalmuo1 = Math.Round(dalmuo1, 3); // atsakyma suapvalina iki 3 skaiciu po kablelio
            Console.WriteLine("Atsakymas " + dalmuo1); // atsakymas 0,857

            double daugyba = 36;
            double cc = Math.Sqrt(daugyba); // galima istraukti kvadratine sakni
            Console.WriteLine(cc);

            int a = 27;
            double saknis = Math.Pow(a, 1.0 / 3.0); // naudojant Pow galima istraukti ir kubine sakni
            Console.WriteLine(saknis);


            
        }
    }
}
