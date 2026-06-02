using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz =
{
{ 1, 2, 3 },
{ 4, 5, 6 }
};
            int suma = 0;
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    suma += matriz[fila, columna];
                }
            }
            Console.WriteLine("Suma total: " + suma);
            Console.ReadKey();
        }
    }
}
