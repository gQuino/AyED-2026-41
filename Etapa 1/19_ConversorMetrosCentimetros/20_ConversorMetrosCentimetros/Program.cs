using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            float metros;
            float centimetros;
            float milimetros;
            Console.Write("Ingrese un numero; ");
            metros = float.Parse(Console.ReadLine());
            centimetros = metros * 100;
            milimetros = metros * 1000;
            Console.Write("Su numero a centimetros es: ");
            Console.WriteLine(centimetros);
            Console.Write("Su numero a milimetros: ");
            Console.WriteLine(milimetros);
            Console.ReadKey();
        }
    }
}
