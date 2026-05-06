using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego_Desafio_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int comidacruda = 0;
            int comidacocida = 0;
            bool refugio = false;
            int materialesfogata = 0;
            int materialesrefugio = 0;
            bool fogata = false;
            while (vida != 8)
            {
            Console.WriteLine("                 ___________________________________          _____________________________");
            Console.WriteLine("                |                                   |        |                             |");
            Console.WriteLine("                |        Bienvenido al juego        |        |     Sobrevive a la Isla     |");
            Console.WriteLine("                |___________________________________|        |_____________________________|");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("|Dias: " + dia);
            Console.WriteLine("|Vida: " + vida);
            Console.WriteLine("|Hambre: " + hambre);
            Console.WriteLine("|Inventario: ");
            Console.WriteLine("Comida Cruda: " + comidacruda);
            Console.WriteLine("Comida Cocinada: " + comidacocida);
            Console.WriteLine("Materiales para hacer una fogata: " + materialesfogata);
            Console.WriteLine("Materiales para hacer un refugio: " + materialesrefugio);
            Console.WriteLine("");
            Console.WriteLine("1. Buscar Comida");
            Console.WriteLine("2. Explorar la isla");
            Console.WriteLine("3. Construir refugio");
            Console.WriteLine("4. Encender fogata");
            Console.WriteLine("5. Cocinar comida");
            Console.WriteLine("6. Comer comida cocida");
            Console.WriteLine("7. Descansar");
            Console.WriteLine("8. Salir");
            Console.Write("Elige la opcion del Dia: ");
            opcion = int.Parse(Console.ReadLine());
               
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Manco");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Explora la isla ");
                        break;
                    case 3:
                        Console.Clear();
                        if (materialesrefugio > 0)
                        {
                            Console.WriteLine("Construyo un refugio");
                        }
                        else
                        {
                            Console.WriteLine("Le faltan recursos para hacer un refugio");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (materialesfogata > 0)
                        {
                            Console.WriteLine("Construyo una fogata");
                            fogata = true;
                        }
                        else
                        {
                            Console.WriteLine("Le faltan recursos para hacer una fogata");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        if (fogata ==  true && comidacruda > 0)
                        {
                            Console.WriteLine("Has encendido la una fogata y cocinaste tu comida");
                        }
                        else
                        {
                            Console.WriteLine("Primero enciende una fogata y consegui comida");
                        }
                        break;

                }
            }







            Console.ReadKey();
        }
    }
}
