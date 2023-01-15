using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12TabliceTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablica tablic 
            // jagged array (tablica postrzępiona)

            string[][] tablicaTablic = new string[4][];

            tablicaTablic[0] = new string[3];
            tablicaTablic[1] = new string[2];
            tablicaTablic[2] = new string[1];
            tablicaTablic[3] = new string[4];

            tablicaTablic[0][0] = "1";
            tablicaTablic[0][1] = "2";
            tablicaTablic[0][2] = "3";

            tablicaTablic[1][0] = "4";
            tablicaTablic[1][1] = "5";

            tablicaTablic[2][0] = "6";

            tablicaTablic[3][0] = "7";
            tablicaTablic[3][1] = "8";
            tablicaTablic[3][2] = "9";
            tablicaTablic[3][3] = "10";





        }
    }
}
