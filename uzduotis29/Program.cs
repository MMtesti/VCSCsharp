/*
 * Papildomi salygu uzdaviniai 13. uzduotis. Perkeliame viska i klase ir static metodus.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis29
{
    class Trikampis
    {
        public int A;
        public int B;
        public int C;


        public Trikampis(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void Gali()
        {
            Console.Write($"Kai trikampio kraštinės yra {A} , {B}, {C}: ");
            if ((A + B) > C && (A + C) > B && (B + C) > A)
            {
                Console.WriteLine("trikampį sudaryti galima");
            }
            else
            {
                Console.WriteLine("trikampį sudaryti negalima");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trikampis tr1 = new Trikampis( 12, 7, 6 );
            Trikampis tr2 = new Trikampis(40, 50, 60);
            Console.WriteLine();
            tr1.Gali();
            tr2.Gali();
            Console.WriteLine();
            ArGali(tr1);
            ArGali(tr2);

        }
        public static void ArGali( Trikampis tr )
        {
            Console.Write($"Kai trikampio kraštinės yra {tr.A} , {tr.B}, {tr.C}: ");
            if ((tr.A + tr.B) > tr.C && (tr.A + tr.C) > tr.B && (tr.B + tr.C) > tr.A)
            {
                Console.WriteLine("trikampį sudaryti galima");
            }
            else
            {
                Console.WriteLine("trikampį sudaryti negalima");
            }
        }
    }
}
