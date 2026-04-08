using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            float dinero;
            float sueldo;
            Console.Write("Ingrese una cantidad de horas: ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese una cantidadde dinero: ");
            dinero = float.Parse(Console.ReadLine());
            sueldo = horas * dinero;
            Console.Write("Su sueldo es: ");
            Console.WriteLine(sueldo);
            Console.ReadKey();

        }
    }
}
