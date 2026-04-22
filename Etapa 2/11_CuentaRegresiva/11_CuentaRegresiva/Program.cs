using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Write("Ingresa una cuenta regresiva: ");
            numero = int.Parse(Console.ReadLine());
            
            while (numero > 0 )
            {
                numero--;
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
