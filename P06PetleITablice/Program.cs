using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06PetleITablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] miasta = { "Warszawa", "Kraków", "Wrocław" };

            int k = 0;
            while (k<miasta.Length)
            {
                Console.WriteLine(miasta[k]);
                k++;
            }

            int suma = 0;
            for (int i = 0; i < miasta.Length; i++)
            {
                suma += miasta[i].Length;
                Console.WriteLine(miasta[i]);
            }

            Console.WriteLine(suma);


        }
    }
}
