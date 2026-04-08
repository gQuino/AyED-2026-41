using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string edad;
            string ciudad;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = Console.ReadLine();
            Console.Write("Ingrese su Ciudad donde vive: ");
            ciudad = Console.ReadLine();
            Console.Write("Estos son sus datos: ");
            Console.Write("Su nombre es " + nombre + " tiene " + edad + " años y vive en " + ciudad);
            Console.ReadKey();
            
        }
    }
}
