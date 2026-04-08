using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int doble;
            int triple;
            Console.Write("Ingrese un numero entero: ");
            numero = int.Parse(Console.ReadLine());
            doble = numero * 2;
            triple = numero * 3;
            Console.Write("El doble de su numero es: ");
            Console.WriteLine(doble);
            Console.Write("El triple de su numero es: ");
            Console.WriteLine(triple);
            Console.ReadKey();

        }
    }
}
