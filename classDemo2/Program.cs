using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDemo2
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int GamybosMetai;
        public int Rida;
        public List<int> Avarijos = new List<int>();

        public Automobilis(string marke, string modelis, int gamybosMetai, int rida, int a, int b, int c)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            Rida = rida;

            Avarijos.Add(a);
            Avarijos.Add(b);
            Avarijos.Add(c);
        }

        public void Informacija()
        {
            Console.WriteLine("Automobilis {0} {1}, pagamintas {2} metais, nuvažiavo {3} km.",
                Marke, Modelis, GamybosMetai, Rida);

            foreach (int item in Avarijos)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        

    }
    class Program
    {

        static void Main(string[] args)
        {
            Automobilis audi = new Automobilis("Audi", "A4", 2005, 10000, 10, 2, 3);
            Automobilis bmw = new Automobilis("BMW", "E39", 1998, 354000, 0, 1, 2);
            Automobilis porche = new Automobilis("Porsche", "911", 2011, 5000, 6, 7, 3);

            audi.Informacija();
            Console.WriteLine();

            audi.Avarijos[1] = 99;
            audi.Informacija();

            Console.WriteLine(audi.Avarijos.First());

            bmw.Informacija();
            porche.Informacija();

            Console.WriteLine(audi.Modelis);
            Console.WriteLine(bmw.Marke);
            porche.GamybosMetai = 1970;

            porche.Informacija();
        }
    }
}
