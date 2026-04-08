using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            double ginecologia;
            double traumatologia;
            double pediatria;
            Console.Write("Ingrese un presupuesto para la primera area: ");
            sueldo = float.Parse(Console.ReadLine());
            ginecologia = sueldo * 0.4;
            traumatologia = sueldo * 0.3;
            pediatria = sueldo * 0.3;
            Console.Write("El sueldo de ginecologia es " + ginecologia + " , el de traumatologia es " + traumatologia + " y el de pediatra " + pediatria);
            Console.ReadKey();

            
        }
    }
}
