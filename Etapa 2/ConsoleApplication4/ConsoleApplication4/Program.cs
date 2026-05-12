using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double cupos = 0;
            Double costo = 2500;
            Double total_recaudado = 0;
            int contraseña = 1234;

            do
            {
                Console.WriteLine("bienvenido elija el numero de su opcion:");
                Console.WriteLine("1: ingresar veiculo");
                Console.WriteLine("2: retirar vehiculo");
                Console.WriteLine("3: consultar estado");
                Console.WriteLine("4: cerrar caja y salir");

                switch

                        case 1:
                    if (cupos < 20)
                        cupos += 1;
                    else
                        Console.WriteLine("estacionamiento lleno");
                    break;

                case 2:
                    if (cupos == 0)
                        Console.WriteLine("error el estacionamiento esta vacio");
                    else
                        Console.WriteLine("monto pagado por el cliente");
                    int monto = int.Parse(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("pago insuficiente");
                        while (monto >= costo) ;

                        int vuelto = monto-- costo;
                        Console.WriteLine("Salida registrada. Su vuelto es: " + vuelto);
                        break;

                        case 3:
                    Console.WriteLine("estado actual: veiculos presentes=" + cupos, "dinero en caja:$" + total_recaudado);
                    break;

                case 4:

                    Console.WriteLine("escribir clave de admin: ");
                    int clave = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("acceso denegado");
                        while (clave == contraseña)
                            Console.WriteLine("Caja cerrada. Total del dia: $" + total_recaudado);
                    }
                }
                Console.ReadKey();
            
        }
    }
}
