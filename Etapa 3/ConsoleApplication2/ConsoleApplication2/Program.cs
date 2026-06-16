using System;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[6];
            int[] ordenados = new int[6];
            int suma = 0;
            double promedio = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];
            }
            int menor = 0;
            promedio = suma / numeros.Length;
            for (int m = 0; m < 6; m++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if(numeros[m] < numeros[j])
                    {
                        menor += 1;
                    }
                }
                if (menor == 5) 
                {
                    ordenados[0] = numeros[m];
                }
                if (menor == 4)
                {
                    ordenados[1] = numeros[m];
                }
                if (menor == 3)
                {
                    ordenados[2] = numeros[m];
                }
                if (menor == 2)
                {
                    ordenados[3] = numeros[m];
                }
                if (menor == 1)
                {
                    ordenados[4] = numeros[m];
                }
                if (menor == 0)
                {
                    ordenados[5] = numeros[m];
                }
                menor = 0;


            }
            Console.WriteLine("suma: " + suma);
            Console.WriteLine("promedio: " + promedio);
            for(int p = 0;p < 6;p++ )
            {
                Console.Write(ordenados[p] + " ");
            }
            Console.ReadKey();
        }
    }
}
