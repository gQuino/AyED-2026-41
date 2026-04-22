using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDeNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int oro;
            int plata;
            int monedaoro;
            int monedaplata;
            int puntos;
            Console.Write("Ingrese su cantidad de monedas doradas: ");
            oro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su cantidad de monedas plateadas: ");
            plata = int.Parse(Console.ReadLine());
            monedaoro = 10;
            monedaplata = 2;
            puntos = oro * monedaoro + plata * monedaplata;
            if (puntos >= 100)
            {
                Console.WriteLine("Tiene " + puntos + " Puntos, Nivel Completado con bonus");

            }
            else if (puntos >= 50 && puntos <= 99)
                {
                Console.WriteLine("Tiene " + puntos + " Puntos, Nivel Superado");
            }
            else
            {
                Console.WriteLine("Tiene " + puntos + " Puntos, Nivel insuficiente");
            }
            Console.ReadKey();


        }
    }
}
