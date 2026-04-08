using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float ancho;
            float altura;
            float perimetro;
            float area;
            double diagonal;
            Console.WriteLine("Querido Usuario ingrese 2 numeros para un rectangulo, para que calculemos su perimetro, area, y su diagonal");
            Console.Write("Ingrese un numero para el ancho: ");
            ancho = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un numero para la altura: ");
            altura = float.Parse(Console.ReadLine());
            perimetro = ancho + ancho + altura + altura;
            area = ancho * altura;
            diagonal = Math.Sqrt(Math.Pow(ancho,2) + Math.Pow(altura,2));
            Console.Write("El perimetro del rectangulo es: ");
            Console.WriteLine(perimetro);
            Console.Write("El area del rectangulo es: ");
            Console.WriteLine(area);
            Console.Write("El diagonal del rectangulo es: ");
            Console.WriteLine(diagonal);
            Console.ReadKey();
        }
    }
}
