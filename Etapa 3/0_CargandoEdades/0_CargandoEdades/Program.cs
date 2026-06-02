using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edad = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese una edad: ");
                edad[i] = int.Parse(Console.ReadLine());

            }
            for (int a = 0; a < 5; a++ )
            {
                Console.WriteLine("Edades de los estudiastes: " + edad[a] );
            }
            Console.ReadKey();
        }
    }
}
