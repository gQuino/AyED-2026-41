using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        { 
            String nombre;
            String apellido;
            int edad;
            int prestacion;

            int menores = 0;
            int mayores = 0;

            int clinica = 0;
            int odontologia = 0;
            int pediatria = 0;

            do
            {
                Console.WriteLine("ingrese su nombre: ");
                nombre = Console.ReadLine();

                if (nombre != "0")
                {
                    Console.WriteLine("Ingrese su apellido: ");
                    apellido = Console.ReadLine();

                    Console.WriteLine("Ingrese su edad: ");
                    edad = int.Parse(Console.ReadLine());

                    Console.WriteLine("Elija una prestación:");
                    Console.WriteLine("1 - Clínica médica");
                    Console.WriteLine("2 - Odontología");
                    Console.WriteLine("3 - Pediatría");

                    prestacion = int.Parse(Console.ReadLine());

                    if (edad < 18)
                        menores++;
                    else
                        mayores++;

                    switch (prestacion)
                    {
                        case 1:
                            clinica++;
                            break;
                        case 2:
                            odontologia++;
                            break;
                        case 3:
                            pediatria++;
                            break;

                        default:
                            Console.WriteLine("prestacion no valida");
                            break;
                    }

                }
            } while (nombre != "0");

            Console.WriteLine("menores: " + menores);
            Console.WriteLine("mayores: " + mayores);
            Console.WriteLine("cantidad de pacientes en clinica: " + clinica);
            Console.WriteLine("cantidad de paciente en odontologia: " + odontologia);
            Console.WriteLine("cantidad de pacientes en pediatria: " + pediatria);

            Console.ReadKey();
        }
    }







}
