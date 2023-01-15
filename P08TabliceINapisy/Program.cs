using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08TabliceINapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zamiana napisu na tablice
            string napis ="ala ma kota";

            string[] wyrazy = napis.Split(' ');

            string napis2 = "ala!*ma^%!*kota";

            string[] separatory = { "!*", "^%" };

            string[] wyrazy2 = napis2.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            // zamiana tablicy na napis 

            string[] tablica = { "jan", "adam", "ola", "lukasz" };

            string wynik = string.Join(" - ", tablica);
            // jan - adam - ola - lukasz
        }
    }
}
