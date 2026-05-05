using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoDe5Opciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int elejir;
            int contador;
            int suma1;
            int suma2;
            int resultadp;
            
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("                                                                           |");
            Console.WriteLine("1. Hola Mundo!                                                             |");
            Console.WriteLine("2. Adios                                                                   |");
            Console.WriteLine("3. Suma de 2 Numeros                                                       |");
            Console.WriteLine("4. Usted selecciono 4                                                      |");
            Console.WriteLine("5. Salir                                                                   |");
            Console.WriteLine("___________________________________________________________________________|");
            Console.Write("Ingrese un numero del 1 al 5 para que seleccione una funcion: ");
            elejir = int.Parse(Console.ReadLine());
            contador = 0;
            while (elejir < 6)
            {
                contador++;
                if (elejir == 1 && contador == 1 )
                {
                    Console.Clear();
                    Console.WriteLine("Hola Mundo");
                }
                else if (elejir == 2 && contador == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Adios");
                }
                else if (elejir == 3 && contador == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese 2 numeros para que se sumen");
                    Console.Write("Ingrese un numero: ");
                    suma1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese otro numero: ");
                    suma2 = int.Parse(Console.ReadLine());
                    resultadp = suma1 + suma2;
                    Console.WriteLine("Su suma salio " + resultadp);
                }
                else if (elejir == 4 && contador == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Usted selecciono 4");
                }
                else if (elejir == 5 && contador == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Salio del programa");
                    
                }
                else if (elejir > 5 && contador == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Error");
                }
                

            }

            Console.ReadKey();


        }
    }
}
