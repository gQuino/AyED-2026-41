using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float ancho;
            float area;
            Console.Write("Ingrese una altura: ");
            altura = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un ancho: ");
            ancho = float.Parse(Console.ReadLine());
            area = (altura * ancho) / 2;
            Console.Write("Su area es: ");
            Console.WriteLine(area);
            Console.ReadKey();

        }
    }
}
