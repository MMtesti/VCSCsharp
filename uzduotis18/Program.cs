using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis18
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 paskaita pdf 42 skaidre
            int[] keliones = { 123, 500, 42, 89, 203, 200, 52, 30, 78, 45 };
            int min, max, suma, sanaudos = 8; // sanaudos l/100 km.
            double visosan;
            min = keliones[0];
            foreach (int kel in keliones) // trumpiausia kelione
            {
                if (kel < min)
                {
                    min = kel;
                }
            }
            Console.WriteLine("Trumpiausia kelionė " + min + ".");
            Console.WriteLine();
            max = keliones[0];
            for (int i = 0; i < keliones.Length; i++)
            {
                if (keliones[i] > max)
                {
                    max = keliones[i];
                }
            }
            Console.WriteLine("Ilgiausia kelionė " + max + ".");
            Console.WriteLine();
            suma = 0;
            for (int i = 0; i <keliones.Length; i++)
            {
                suma += keliones[i];
            }
            visosan = (double)suma / sanaudos;
            visosan = Math.Round(visosan,2);
            Console.WriteLine("Automobilis nuvažiavo viso " + suma + " km ir sunaudojo viso " + visosan + " l kuro." );
        }
    }
}
