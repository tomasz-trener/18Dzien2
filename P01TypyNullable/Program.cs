using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // znak zapytania przy zmiennych 
            // oznacza, ze pozwalamy danej zmiennej
            // na przechowywanie nulii

            int? a = null;
            // poprzez znak zapytania
            // pozwalamy typowi int przechowywać wartość pustą 


            if (a != null)
            {
                Console.WriteLine(a);
            }

            string b = null;
            // w przypadku napisow nie musze pozwalac na przechowywanie
            // wartosci pustych poniewaz string jest 
            // z definicji typem nullable 


            // inna sytuacja :
            // znak zapytania przy tzw operatorze 
            // trójargumrntowym 

            string typWZrostu;
            int wzrost = 180;
            if (wzrost > 175)
                typWZrostu = "wysoki";
            else
                typWZrostu = "niski";

            // możemy ten zapis uprościć stosując operator 
            // trój arugmentowy:

            string typWzrostu2 = wzrost > 175 ? "wysoki" : "niski";



        }
    }
}
