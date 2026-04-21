using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius;
            
            Console.Write("Ingrese una temperatura: ");
            celcius = float.Parse(Console.ReadLine());
            if (celcius <= 0)
            {
                Console.Write("El agua se congelo");
            }
            if (celcius >= 1 && celcius <= 99)
            {
                Console.Write("El agua esta en esto liquido");
            
            }
            if (celcius >= 100)
            {
                Console.Write("El agua se evaporo");
            }
            Console.ReadKey();
        }
    }
}
