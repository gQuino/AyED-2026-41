using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string Si;
            Console.Write("Ingrese si quiere terminar el programa: ");
            palabra = Console.ReadLine();
            Si = "SI";

            while ( palabra != Si)
            {
                Console.Write("Ingrese si quiere terminar el programa: ");
                palabra = Console.ReadLine();


            }
            Console.ReadKey();
        }
    }
}
