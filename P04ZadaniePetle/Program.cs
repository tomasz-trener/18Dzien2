using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadaniePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wczytaj zdanie");
            string zdanie = Console.ReadLine();
            Console.WriteLine("Podaj wyraz lub znak");
            string wyraz = Console.ReadLine();

            int suma = 0;
            int i = 0;

            while (i<=zdanie.Length - wyraz.Length)
            {
                string podciag= zdanie.Substring(i, wyraz.Length);
                if (podciag == wyraz)
                    suma++;      
                i++;
            }

            string raport = $"W zdaniu '{zdanie}' wyraz '{wyraz}' występuje {suma} razy";
            Console.WriteLine(raport);
            Console.ReadKey();

        }
    }
}
