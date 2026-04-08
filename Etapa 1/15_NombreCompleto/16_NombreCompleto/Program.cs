using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Su nombre y apellido son: ");
            Console.Write(nombre);
            Console.Write(" ");
            Console.Write(apellido);
            
            Console.ReadKey();
            
        }
    }
}
