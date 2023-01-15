using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] napisy = { "jeden", "dwa", "trzy" };

            List<string> lista0 = null;
            List<string> lista = new List<string>();
            lista.Add("jeden");
            lista.Add("dwa");
            lista.Add("trzy");

            int dlugoscTablicy = napisy.Length;
            int dlugoscListy = lista.Count();

            string ostatniElement = lista[dlugoscListy - 1];

            lista.Insert(1, "x");

            lista.RemoveAt(2); // teraz zostanie usuniety "dwa"
            lista.RemoveAt(1); // teraz zostanie usuniety "x" 

            // teraz nasza lista to : jeden, trzy 







        }
    }
}
