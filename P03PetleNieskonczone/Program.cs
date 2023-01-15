using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PetleNieskonczone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wersja 1:
            //string dane = null;
            //while (dane != "koniec")
            //{
            //    Console.WriteLine("Podaj kolejno dwie liczby lub napisz 'koniec'");
            //    dane = Console.ReadLine();
            //    if (dane != "koniec")
            //    {
            //        int liczba1 = Convert.ToInt32(dane);
            //        int liczba2 = Convert.ToInt32(Console.ReadLine());

            //        int wynik = liczba1 + liczba2;
            //        Console.WriteLine("wynik to: " + wynik);
            //    }         
            //}

            // wersja 2: 
            while (true)
            {
                Console.WriteLine("Podaj kolejno dwie liczby lub napisz 'koniec'");
                string dane = Console.ReadLine(); // wczytanie pierwszej

                if (dane == "koniec")
                    break;

                int liczba1 = Convert.ToInt32(dane);

                dane = Console.ReadLine(); // wczytanie drugiej liczby
                if (dane == "koniec")
                    break;

                int liczba2 = Convert.ToInt32(dane);
              
                
                int wynik = liczba1 + liczba2;
                Console.WriteLine("wynik to: " + wynik);
            }

            

        }
    }
}
