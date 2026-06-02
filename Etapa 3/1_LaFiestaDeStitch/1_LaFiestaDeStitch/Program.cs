using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int promedio_de_com_por_inv;
            int cantidad_invitados;
            int cantidad_de_comida;
            int comida_por_invitado;
            Console.Write("Cuantos invitados habra: ");
            cantidad_invitados = int.Parse(Console.ReadLine());
            Console.Write("Cuanta comida daras por cada invitado: ");
            comida_por_invitado = int.Parse(Console.ReadLine());
            while(comida_por_invitado < 1 || comida_por_invitado > 100)
            {
                
                Console.WriteLine("Cuanta comida daras a cada invitado?: ");
                comida_por_invitado = int.Parse(Console.ReadLine());
            }
            cantidad_de_comida = comida_por_invitado * cantidad_invitados;
            promedio_de_com_por_inv = cantidad_invitados / cantidad_invitados;
            Console.WriteLine("El promedio es " + promedio_de_com_por_inv);
            Console.ReadKey();
        }
    }
}
