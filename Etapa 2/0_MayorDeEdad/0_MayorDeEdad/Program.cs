using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.Write("Eres mayor de edad tenes " + edad + " años");
            }
            else
            {
                Console.Write("Eres menor de edad tenes " + edad + " años");
                Console.ReadKey();
            }
        }
    }
}
