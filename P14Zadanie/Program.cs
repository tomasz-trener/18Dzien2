using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int suma = liczba1 + liczba2;

            Console.WriteLine(suma);
            //http://pl.spoj.com/problems/JHTMLLET/ 


            string[] tab = { "a", "b", "c" };

            List<string> lista = tab.ToList();

            string[] tab2 = lista.ToArray();
        }
    }
}
