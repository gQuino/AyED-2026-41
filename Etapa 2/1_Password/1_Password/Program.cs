using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña;
            string contraseñaintro = "contraseña";
            Console.Write("Ingrese su contraseña: ");
            contraseña = Console.ReadLine();           
            if (contraseñaintro.ToLower() == contraseña.ToLower())
            {
                Console.Write("Su contraseña es corecta");
            }
            else
            {
                Console.Write("Su contraseña es incorecta");
            }
            Console.ReadKey();
        }
    }
}
