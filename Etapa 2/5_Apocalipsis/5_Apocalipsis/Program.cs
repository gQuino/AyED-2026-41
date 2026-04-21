using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool comida;
            bool refugio;
            bool bate;
            bool agua;
            Console.Write("Tiene comida: ");
            comida = bool.Parse(Console.ReadLine());
            Console.Write("Tiene refugio: ");
            refugio = bool.Parse(Console.ReadLine());
            Console.Write("Tiene bate: ");
            bate = bool.Parse(Console.ReadLine());
            Console.Write("Tiene agua: ");
            agua = bool.Parse(Console.ReadLine());
            if (comida == true && refugio == true && bate == true && agua == true)
            {
                Console.Write("Va a sobrevivir");
            }

            else if (comida == true && refugio == false && bate == true && agua == true)
            {
                Console.Write("Va a sobrevivir");
            }
            else
            {
                Console.Write("No va a sobrevivir");
            }
            Console.ReadKey();
        }
    }
}
