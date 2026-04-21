using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Tipo_de_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float angulo1;
            float angulo2;
            float angulo3;
            Console.WriteLine("Por favor ingrese 3 lados para saber que tipo de triangulo es");
            Console.Write("Ingrese un angulo: ");
            angulo1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro angulo: ");
            angulo2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese otro angulo: ");
            angulo3 = float.Parse(Console.ReadLine());
            if (angulo1 == angulo2 && angulo1 == angulo3 && angulo3 == angulo2 )
            {
                Console.WriteLine("Su triangulo es Equilatero");
            }
            else if (angulo1 != angulo2 && angulo2 != angulo3 && angulo3 != angulo1)
            {
                Console.WriteLine("Su triangulo es Escaleno");
            }
            else 
            {
                Console.WriteLine("Su triangulo es Isoceles");
            }


            if (angulo1 + angulo2 >= angulo3 && angulo1 + angulo3 >= angulo2 && angulo2 + angulo3 >= angulo1)
            {
                Console.WriteLine("Su triangulo existe");
            }
            else
            {
                Console.WriteLine("Su triangulo no existe");
                    }
            
            
            
            Console.ReadKey();
        }
    }
}
