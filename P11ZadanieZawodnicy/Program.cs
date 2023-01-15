using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P11ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wczytaj kraj");
            string kraj = Console.ReadLine().ToLower();

            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane = new WebClient().DownloadString(url);

            string[] separatory = { "\r\n" }; // nowa linia 

            string[] wiersze = dane.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            List<string> zawodnicy = new List<string>(); // tutaj bedziemy przechowywac imiona i nazwiska
            // zawodnikow 

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                     zawodnicy.Add(komorki[2] + " " + komorki[3] + " " + komorki[6]);
                    //zawodnicy.Add(wiersze[i]);
            }
            string zawartosc = string.Join("\r\n", zawodnicy);
            File.WriteAllText("c:\\dane\\" + kraj + ".txt", zawartosc);

        }
    }
}
