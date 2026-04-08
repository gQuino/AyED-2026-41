using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius;
            double farenheit;
            double kelvin;
            Console.WriteLine("Querido Usuario ingrese un numero para calcular a farenheit y a kelvin");
            Console.Write("Ingrese un numero: ");
            celcius = float.Parse(Console.ReadLine());
            farenheit = (1.8 * celcius) + 32;
            kelvin = -273.15 + celcius;
            Console.Write("De celcius a farenheit es: ");
            Console.WriteLine(farenheit);
            Console.Write("De celcius a kelvin: ");
            Console.WriteLine(kelvin);
            Console.ReadKey();
             
        }
    }
}
