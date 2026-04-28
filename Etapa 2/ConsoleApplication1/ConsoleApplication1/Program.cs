using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Tienes comida?");
            String comida = Console.ReadLine();

            Console.WriteLine("¿Tienes refugio?");
            String refugio = Console.ReadLine();

            Console.WriteLine("¿Tienes un bate?)");
            String bate = Console.ReadLine();
         
            if (comida == "si" && refugio == "si" && bate == "si")
            {
                Console.WriteLine("Podrás Sobrevivir");
            }
            else
            {
                Console.WriteLine("No podrás sobrevivir");
            }

            Console.ReadKey();
        }
    }
}
