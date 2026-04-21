using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {                   
            float numero;
            Console.Write("Ingrese un numero: ");
            numero = float.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.Write("Su numero es par");

            }
            else
            {
                Console.Write("Su numero es impar");
            }
            Console.ReadKey();
        }
    }
}
