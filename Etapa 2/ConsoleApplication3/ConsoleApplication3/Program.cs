using System;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
          String descuento = "";
            int entradavip = 2;
            int edad; 
            int general = 2000;
            int vip = 5000;
            int entradagral = 1;
            int descvip = vip - 1500;
            int descgral = general - 600;

            do
            {
                Console.WriteLine("¿que edad tienes?");
                edad = int.Parse(Console.ReadLine());

                if (edad > 120)
                {
                    Console.WriteLine("invalido");
                }

                    else if (edad >= 18)
                    {
                        Console.WriteLine("elija una entrada: 1-Para general y 2- Para vip");
                    }
                    else
                    {
                        Console.WriteLine("acceso denegado, menor de edad");
                    }
                if (entradagral != 1 && entradavip != 2)
                {
                    Console.WriteLine("entrada invalida");
                    entradagral = int.Parse(Console.ReadLine());
                    entradavip = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("¿tenes descuento de estudiante?");
                    descuento = Console.ReadLine();
                }
                if (descuento == "si")
                {
                    Console.WriteLine(descvip);
                    Console.WriteLine(descgral);
                    descvip = int.Parse(Console.ReadLine());
                    descgral = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("no se aplico el descuento");
                }
            }
              while(edad > 120); 

              Console.WriteLine("su edad es: " + edad);
              Console.WriteLine("tipo de entrada: " + entradagral + entradavip);
              Console.WriteLine("aplico descuento: " + descuento);
              Console.WriteLine("precio final:" + general + vip + descvip + descgral);
              Console.ReadKey();
        }
    }
}
