using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieListy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> temperatury = new List<int>();
            List<string> miasta = new List<string>();
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
                //Console.WriteLine(wynik);

                if (!miasta.Contains(miasto)) // dodajemy temperature do średniej tylko wtedy gdy wcześniej tego miasta nie sprawdzaliśmy
                {
                    temperatury.Add(Convert.ToInt32(wynik.Substring(0, wynik.Length - 2)));
                    miasta.Add(miasto); // przechowujemy historię wczesniej sprawdzonych miast, zeby nie wpowarzac liczenia sredniej dla tego samego miasta 
                }
                    // chodzi o to aby gdy ktoś kilka razy poda to samo miasto, to średnia nie była liczona wielkrotnie

                // liczenie sredniej jako suma przez liczba elementow 
                double suma = 0;
                for (int i = 0; i < temperatury.Count(); i++)
                    suma += temperatury[i];

                double srednia = Math.Round(suma / temperatury.Count(),2);
                Console.WriteLine($"temp: {wynik} | średnia temp: {srednia}");
                 

            }
        }
    }
}
