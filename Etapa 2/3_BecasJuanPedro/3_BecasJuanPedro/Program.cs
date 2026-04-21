using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float edad;
            float ingresos;
            Console.Write("Ingrese su edad: ");
            edad = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su ingresos: ");
            ingresos = float.Parse(Console.ReadLine());
            if (edad > 19 && ingresos <= 100000)
            {
                Console.Write("Puede cobrar la beca");
            }
            

            else if (edad < 19 && ingresos == 0)
            {
                Console.Write("Puede cobrar la beca");
            }
            
            else if (edad == 19 && ingresos == 50000)
            {
                Console.Write("Puede cobrar la beca");
            }
            else
            {
                Console.Write("No puede cobrar la beca");
            }
            Console.ReadKey();
        }
    }
}
