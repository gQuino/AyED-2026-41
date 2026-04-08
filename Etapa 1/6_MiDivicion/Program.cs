using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiDivicion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.WriteLine("Querido Usuario");
            Console.WriteLine("Si es tan amable ingrese 2 numeros enteros enteros para hacer una divicion sofisticada");
            Console.Write("Ingrese un numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1/numero2;
            Console.Write("Gracias por poner sus numeros, su resultado es: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
