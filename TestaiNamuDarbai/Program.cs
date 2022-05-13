/*
 * 1 paskaita pdf
 * paskutinis namu darbas apie kvadrata ir uzrasa jame
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaiNamuDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Milda";

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

            /* 
           pakeisti fono spalva
           Console.BackgroundColor = ConsoleColor.DarkCyan;
           Console.WriteLine("|           Tomas          |");
           Console.WriteLine("aaa");
           Console.BackgroundColor = ConsoleColor.Black;
           */


            char remelis = '-';
            string remelis1 = "|              |";


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


        }
    }
}
