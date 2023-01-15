using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();
                string url = $"https://www.google.com/search?q=pogoda+{miasto}";
                string dane = new WebClient().DownloadString(url);
                //   Console.WriteLine(dane);
                //File.WriteAllText("c:\\dane\\strona.html", dane);

                string szukanyZnak = "°";
                string znakKoncowy = ">";

                int indx = dane.IndexOf(szukanyZnak);
                int aktualnaPozycja = indx;

                while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                    aktualnaPozycja--; // zmniejsz o 1     aktualnapozycja = atktualnapozycja - 1

                string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);
                Console.WriteLine(wynik);
            }   
        }
    }
}
