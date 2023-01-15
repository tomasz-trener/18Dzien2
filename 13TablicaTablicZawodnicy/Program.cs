using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _13TablicaTablicZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = new WebClient().DownloadString(url);
            string[] separatory = { "\r\n" }; // nowa linia 
            string[] wiersze = dane.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            string[][] tab = new string[wiersze.Length-1][];

            for (int i = 1; i < wiersze.Length; i++)
                tab[i - 1] = wiersze[i].Split(';');


            Console.WriteLine(tab[4][3]);
          
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i][3]);

            Console.ReadKey();

        }
    }
}
