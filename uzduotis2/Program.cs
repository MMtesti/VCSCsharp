using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Milda";

            Console.WriteLine("1 variantas");

            Console.WriteLine("1  ----------------");
            Console.WriteLine("2  |              |");
            Console.WriteLine("3  |              |");
            Console.WriteLine("4  |  Mano vardas |");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"5  |    {vardas}     |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("6  |              |");
            Console.WriteLine("7  |              |");
            Console.WriteLine("8  ----------------");

            char remelis = '-';
            string remelis1 = "|              |";

            Console.WriteLine("2 variantas");
            Console.WriteLine();
            Console.Write("1  ");
            Console.WriteLine(string.Concat(Enumerable.Repeat(remelis, 16)));
            Console.Write("2  ");
            Console.WriteLine(remelis1);
            Console.Write("3  ");
            Console.WriteLine(remelis1);
            Console.WriteLine("4  |  Mano vardas |");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"5  |    {vardas}     |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("6  ");
            Console.WriteLine(remelis1);
            Console.Write("7  ");
            Console.WriteLine(remelis1);
            Console.Write("8  ");
            Console.WriteLine(string.Concat(Enumerable.Repeat(remelis, 16)));
            Console.WriteLine();

            Console.WriteLine("3 variantas");
            Console.WriteLine();
            Console.WriteLine(string.Concat(Enumerable.Repeat(remelis, 16)));
            Console.WriteLine(remelis1);
            Console.WriteLine(remelis1);
            Console.WriteLine("|  Mano vardas |");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"|    {vardas}     |");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(remelis1);
            Console.WriteLine(remelis1);
            Console.WriteLine(string.Concat(Enumerable.Repeat(remelis, 16)));
            Console.WriteLine();


            Console.WriteLine("4 variantas");
            char a = '-';
            char b = '|';
            string tarpas = " ";

            Console.WriteLine(string.Concat(Enumerable.Repeat(a, 16)));
            Console.Write(b);
            Console.Write(string.Concat(Enumerable.Repeat(tarpas, 14)));
            Console.WriteLine(b);
            Console.Write(b);
            Console.Write(string.Concat(Enumerable.Repeat(tarpas, 14)));
            Console.WriteLine(b);
            Console.WriteLine("{0}{1}{1}Mano vardas{1}{0}", b, tarpas);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0}{1}{1}{1}{1}{1}{2}{1}{1}{1}{1}{0}", b, tarpas, vardas);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(b);
            Console.Write(string.Concat(Enumerable.Repeat(tarpas, 14)));
            Console.WriteLine(b);
            Console.Write(b);
            Console.Write(string.Concat(Enumerable.Repeat(tarpas, 14)));
            Console.WriteLine(b);
            Console.WriteLine(string.Concat(Enumerable.Repeat(a, 16)));

            // uzduotis is 5 skaidres 2 paskaita

            Console.WriteLine("********");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("*      *");
            Console.WriteLine("********");

            string zvaig = "*";
            string vidurys = "*              *";
            Console.WriteLine(string.Concat(Enumerable.Repeat(zvaig, 16)));
            Console.WriteLine("{0}\n{0}\n{0}\n{0}\n{0}", vidurys);
            Console.WriteLine(string.Concat(Enumerable.Repeat(zvaig, 16)));

            string blokas = "****\n*  *\n*  *\n****";
            Console.WriteLine(blokas);
            Console.WriteLine();

            Console.WriteLine("****\n*  *\n*  *\n****");



            string marke = "Opel";
            string modelis = "Insignia";
            int metai = 2015;
            int rida = 125000;

            Console.WriteLine($"Automobilio {marke} {modelis} ({metai} m.) rida - {rida} km.");
            Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km.", marke, modelis, metai, rida);

        }
        
    }
}
