using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            double cuadrado;
            double cubo;
            Console.Write("Ingrese un numero: ");
            numero = float.Parse(Console.ReadLine());
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);
            Console.Write("Su numero al cuadrado es: ");
            Console.WriteLine(cuadrado);
            Console.Write("Su numero al cubo es: ");
            Console.WriteLine(cubo);
            Console.ReadKey();
        }
    }
}
