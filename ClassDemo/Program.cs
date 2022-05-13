using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Zmogus
    {
        public string Vardas;
        public string Pavarde;
        public int Amzius;
        public string Profesija;
        public double Ugis;

        public Zmogus() { }

        public Zmogus(string vardas, int amzius)
        {
            Vardas = vardas;
            Amzius = amzius;
        }

        public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public Zmogus(string vardas, string pavarde, int amzius, string profesija, double ugis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Profesija = profesija;
            Ugis = ugis;
        }

        public void Informacija()
        {
            Console.WriteLine("{0} {1} ({2} m.), ūgis {3}.",
                Vardas, Pavarde, Amzius, Ugis);
            Console.WriteLine("Dirba: {0}", Profesija);
            Console.WriteLine();
        }

        public int KiekMetuJauDarbingas()
        {
            return Amzius - 18;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zmogus X = new Zmogus();
            Zmogus Y = new Zmogus("Ona", 25);

            Zmogus petras = new Zmogus("Petras", "Petraitis", 34, "Kasininkas", 1.8);
            Zmogus jonas = new Zmogus("Jonas", "Jonaitis", 45, "Vairuotojas", 1.7);
            Zmogus paulius = new Zmogus("Paulius", "Pauliukaitis", 21, "Video prodiuseris", 1.75);

            petras.Informacija();
            jonas.Informacija();
            paulius.Informacija();

            Console.WriteLine("Šie žmonės jau darbingi metų:");
            Console.WriteLine(petras.KiekMetuJauDarbingas());
            Console.WriteLine(jonas.KiekMetuJauDarbingas());
            Console.WriteLine(paulius.KiekMetuJauDarbingas());
            Console.WriteLine();

            Zmogus auksciausias = Auksciausias(petras, jonas, paulius);
            Console.WriteLine("Informacija apie aukščiausią žmogų");
            auksciausias.Informacija();

            Console.WriteLine("Tik vardai ir pavardės");
            IsvestiVardus(petras, jonas, paulius);
            Console.WriteLine();
        }

        public static Zmogus Auksciausias(Zmogus z1, Zmogus z2, Zmogus z3)
        {
            if (z1.Ugis > z2.Ugis && z1.Ugis > z3.Ugis)
            {
                return z1;
            }
            else if (z2.Ugis > z1.Ugis && z2.Ugis > z3.Ugis)
            {
                return z2;
            }
            else
            {
                return z3;
            }
        }

        public static void IsvestiVardus(Zmogus z1, Zmogus z2, Zmogus z3)
        {
            Console.WriteLine(z1.Vardas + " " + z1.Pavarde);
            Console.WriteLine(z2.Vardas + " " + z2.Pavarde);
            Console.WriteLine(z3.Vardas + " " + z3.Pavarde);
        }
    }
}
