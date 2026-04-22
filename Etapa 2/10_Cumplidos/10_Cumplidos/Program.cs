using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            int edad;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            contador = 0;
            while (contador < edad)
            {
                contador++;
                Console.WriteLine(contador);

            }
            Console.ReadKey();
        }
    }
}
