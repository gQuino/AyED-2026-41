using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            float cilindros;
            float pistacilindro;
            float sectores;
            float kilobytes;
            float megabytes;
            float gigabytes;
            float totaldebytes;
            Console.Write("Ingrese una cantidad de cilindros: ");
            cilindros = float.Parse(Console.ReadLine());
            Console.Write("Ingrese una cantidad de cilindros: ");
            pistacilindro = float.Parse(Console.ReadLine());
            Console.Write("Ingrese una cantidad de cilindros: ");
            sectores = float.Parse(Console.ReadLine());
            totaldebytes = cilindros * pistacilindro * sectores * 512;
            kilobytes = totaldebytes / 1000;
            megabytes = totaldebytes / 1000000;
            gigabytes = totaldebytes / 1000000000;
            Console.Write("Su cantidad de kb es " + kilobytes + " , la cantidad en mb es " + megabytes + " y la cantidad en gb es " + megabytes);
            Console.ReadKey();
            
        }
    }
}
