using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.Write("Ingrese en que año esta: ");
            año = int.Parse(Console.ReadLine());
            if (año %4 == 0 && año %100 == 0)
            {
                Console.Write("Es año bisiesto");
            }
            else
            {
                Console.Write("No es Año bisiesto");
            }
            Console.ReadKey();
        }
    }
}
