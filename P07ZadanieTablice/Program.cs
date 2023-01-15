using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] imiona = new string[100];

            // wersja while 
            //int i = 0;
            //string imie=null;
            //while (imie != "koniec")
            //{
            //    imie = Console.ReadLine();
            //    imiona[i] = imie;
            //    i++;
            //}

            int i = 0;
            string imie;
            do
            {
                imie = Console.ReadLine();
                imiona[i] = imie;
                i++;
            } while (imie != "koniec");


            // teraz je wyświetlamy 
            for (int j = 0; j < i-1; j++)
                if (imiona[j].Length>3)
                    Console.WriteLine($"{imiona[j]} ({imiona[j].Length})");

            Console.ReadKey();
        }
    }
}
