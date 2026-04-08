using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            float perimetro;
            double superficie;
            Console.Write("Ingrese un numero: ");
            numero = float.Parse(Console.ReadLine());
            perimetro = numero + numero + numero + numero;
            superficie = Math.Pow(numero, 2);
            Console.Write("Su perimetro es: ");
            Console.WriteLine(perimetro);
            Console.Write("Su superficie es: ");
            Console.WriteLine(superficie);
            Console.ReadKey();

        }
    }
}
