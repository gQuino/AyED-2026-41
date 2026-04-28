using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while ( numero > 0)
            {
                numero--;
                
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();   
        }
    }
}
