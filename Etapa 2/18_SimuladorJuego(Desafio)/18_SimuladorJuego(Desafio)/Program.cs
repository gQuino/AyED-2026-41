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
            int vida = 10;
            int hambre = 10;
            int dia = 1;
            int cantidad_de_comida_cruda = 0;
            int cantidad_de_comida_cocida = 3;
            int materiales_utiles = 0;
            int opcion = 0;
            bool fogata = false;
            bool refugio = false;
            int probabilidad;

            Console.WriteLine("BIENVENIDO AL JUEGO");
            Console.WriteLine("TRAMA: SOBREVIVE EN LA ISLA");
            Random rand = new Random();

           
            while (opcion != 8 && vida > 0)
            {
                Console.Clear();
                Console.WriteLine(" __________________            _______________________");
                Console.WriteLine("|                  |          |                       |");
                Console.WriteLine("|    Bienvenido    |          |  Sobrevive a la Isla  |");
                Console.WriteLine("|__________________|          |_______________________|");
                Console.WriteLine("");
                Console.WriteLine("DIA: " + dia);
                Console.WriteLine("VIDA: " + vida);
                Console.WriteLine("HAMBRE: " + hambre);
                Console.WriteLine("Cantidad de comida cruda : " + cantidad_de_comida_cruda);
                Console.WriteLine("Cantidad de comida cocida : " + cantidad_de_comida_cocida);
                Console.WriteLine("Cantidad de materiales utiles: " + materiales_utiles);
                Console.WriteLine(" ");
                Console.WriteLine("Que vas a hacer?¿: ");
                Console.WriteLine(" ");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Explorar la isla");
                Console.WriteLine("3. Construir refugio");
                Console.WriteLine("4. Encender fogata");
                Console.WriteLine("5. Cocinar comida cruda");
                Console.WriteLine("6. Comer comida cruda");
                Console.WriteLine("7. Descansar");
                Console.WriteLine("8. Salir");
                Console.Write("Elige una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Saliste a buscar comida");
                        probabilidad = rand.Next(1, 100);
                        if (probabilidad <= 60)
                        {
                            Console.WriteLine("Y tuviste suerte si encontraste");
                            Console.WriteLine("Pero por esta busqueda perdiste un punto de vida por el cansancio");
                            cantidad_de_comida_cruda = cantidad_de_comida_cruda + 2;
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.WriteLine("Que pena.... No conseguiste nada");
                            Console.WriteLine("Por esta busqueda perdiste un punto de vida por el cansancio");
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Saliste a explorar...");
                        probabilidad = rand.Next(1, 100);
                        if (probabilidad <= 50)
                        {
                            Console.WriteLine("Tuviste suerte encontraste un material");
                            Console.WriteLine("Pero perdiste una vida por que te has cansado");
                            materiales_utiles++;
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else if (probabilidad > 50 && probabilidad <= 80)
                        {
                            Console.WriteLine("No encontraste nada util y perdiste una vida");
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        else
                        {
                            Console.WriteLine("Uh, tuviste un accidente y perdiste dos vidas =( ");
                            dia++;
                            vida = vida - 2;
                            hambre = hambre - 2;
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (refugio == false && materiales_utiles < 3)
                        {
                            Console.WriteLine("No tiene materiales suficientes");
                        }
                        else if (refugio == true)
                        {
                            Console.WriteLine("Ya tienes un refugio");
                        }
                        else
                        {
                            Console.WriteLine("Felicidades contruiste tu refugio. Perdiste una vida.");
                            refugio = true;
                            dia++;
                            vida--;
                            hambre = hambre - 2;
                        }
                        break;

                    case 4:
                        Console.Clear();
                        if (refugio == true && materiales_utiles >= 2)
                        {
                            Console.WriteLine("Felicidades encendiste tu fogata");
                            fogata = true;
                        }
                        else if (fogata == true)
                        {
                            Console.WriteLine("Usted ya tiene la fogata encendida");
                        }
                        else
                        {
                            Console.WriteLine("Necesitas un refugio y materiales para encenderla");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        if (fogata == true && cantidad_de_comida_cruda >= 1)
                        {
                            Console.WriteLine("Cocinaste una comida cruda");
                            cantidad_de_comida_cruda--;
                            cantidad_de_comida_cocida++;
                            dia++;
                        }
                        else
                        {
                            Console.WriteLine("No podes cocinar (necesitas fogata y comida)");
                        }
                        break;

                    case 6:
                        Console.Clear();
                        if (cantidad_de_comida_cocida >= 1)
                        {
                            Console.WriteLine("Consumiste comida cocida. +4 hambre");
                            cantidad_de_comida_cocida--;
                            hambre = (hambre + 4 > 10) ? 10 : hambre + 4;
                        }
                        else
                        {
                            Console.WriteLine("No tienes comida cocida");
                        }
                        break;

                    case 7:
                        Console.Clear();
                        if (refugio == true)
                        {
                            if (vida >= 10) Console.WriteLine("Vida completa");
                            else
                            {
                                Console.WriteLine("Descansaste, sumaste 3 de vida");
                                vida = (vida + 3 > 10) ? 10 : vida + 3;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tienes un refugio");
                        }
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("Has salido del juego.");
                        break;
                }

                
                if (vida <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(" _______________________________");
                    Console.WriteLine("|       ¡HAS PERDIDO!           |");
                    Console.WriteLine("|   Tu vida ha llegado a 0.     |");
                    Console.WriteLine("| Sobreviviste " + dia + " días |");
                    Console.WriteLine("|_______________________________|");
                    Console.WriteLine("Presiona cualquier tecla para cerrar...");
                    Console.ReadKey();
                }
                else if (opcion != 8)
                {
                    Console.WriteLine("\nPresione una tecla para continuar");
                    Console.ReadKey();
                }
            }

            
            if (opcion == 8 && vida > 0)
            {
                Console.WriteLine("Has sobrevivido a la isla " + dia + " dias!");
                
            }
            Console.ReadKey();
        }
        
    }
}

