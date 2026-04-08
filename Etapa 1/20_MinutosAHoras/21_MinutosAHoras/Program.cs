using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int horas;
            float minutossobras;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            horas = numero / 60;
            minutossobras = numero % 60;
            Console.Write("El tiempo es " + horas + " horas con " + minutossobras + " minutos ");
            Console.ReadKey();
            

        }
    }
}
