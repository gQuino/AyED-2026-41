using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            String letras;
            Console.WriteLine("Usuario ingrese 3 letras para ponerlo en orden inverso");
            Console.Write("ingresa 3 letras: ");
            letras = Console.ReadLine();
            Console.Write("Su inverso es: ");
            Console.Write(letras[2]);
            Console.Write(letras[1]);
            Console.Write(letras[0]);
            Console.ReadKey();
            



        }
    }
}
