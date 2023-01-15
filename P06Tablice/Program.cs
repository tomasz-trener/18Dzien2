using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto1 = "warszawa";
            string miasto2 = "kraków";
            string miasto3 = "wrocław";


            string[] miasta = new string[3];

            miasta[0] = "warszawa";
            miasta[1] = miasto2;

            Console.WriteLine(miasta[0]);
            Console.WriteLine(miasta[2]);
            Console.WriteLine(miasta[1]);


            int?[] liczby = new int?[3];
            liczby[0] = 1;

            Console.WriteLine(liczby[1]);

            bool?[] znakiLogiczne = new bool?[3];


            // uproszczony sposób tworzenia tablic 

            string[] miasta2 = { "Kraków", "Warszawa", "Wrocław" };
            int[] liczby2= { 1, 2, 3};

            Console.WriteLine(miasta2[2]);

            Console.ReadKey();
        }
    }
}
