using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringConfirmar = " ";
            string nombre = " ";
            string apellido = " ";
            int edad = 0;
            string mail = " ";
            do
            {
                Console.Clear();

                Console.WriteLine("Ingrese su nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su apellido");
                apellido = Console.ReadLine();

                Console.WriteLine("Ingrese su edad:");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese su email:");
                mail = Console.ReadLine();

                //Mostrar datos
                Console.Clear();
                Console.WriteLine("Datos ingresados:");
                Console.WriteLine($"Nombre:{nombre}\nApellido:{apellido}\nEdad:{edad}\nEmail:{mail}");

                Console.WriteLine("Los datos son correctos?-Ingrese S para confirmar o N para reingresar los datos");
                stringConfirmar = Console.ReadLine();

            } while (stringConfirmar == "N");

            //menu
            
            string carrera = " ";
            int opcion=0;
            string confirmacion = " ";
            string[] materias = new string[3];
            int contador = 0;
            do
            {
                Console.WriteLine("Seleccione el codigo de la carrera elegida.");
                Console.WriteLine("1-Programacion .NET\n2-Programacion JAVA\n3-Programacion PHP");
                opcion=Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        //aca pongo las materias del
                        do
                        {
                            Console.WriteLine("Seleccione las materias que desea agregar.");
                            Console.WriteLine("Materias:");
                            Console.WriteLine("1-Programacion\n2-Matematica\n3-Expresion de problemas");
                            int opcionMateria = Convert.ToInt32(Console.ReadLine());
                            
                            switch (opcionMateria)
                            {
                                case 1:
                                    materias[contador] = "Programacion";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                case 2:
                                    materias[contador] = "Matematica";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                case 3:
                                    materias[contador] = "Expresion de problemas";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Ese materia no existe.");
                                    confirmacion = "S";
                                    break;

                            }
                        } while (confirmacion == "S");
                        Console.Clear();
                        Console.WriteLine("Datos del Alumno:");
                        carrera = "Programacion .NET";
                        Console.WriteLine($"Nombre:{nombre}\nApellido:{apellido}\nEdad:{edad}\nEmail:{mail}\nCarrera:{carrera}");
                        Console.Write("Materas:");
                        foreach(string i in materias)
                        {
                            Console.Write($"{i}-");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Seleccione las materias que desea agregar.");
                            Console.WriteLine("Materias:");
                            Console.WriteLine("1-Programacion\n2-Matematica\n3-Expresion de problemas");
                            int opcionMateria = Convert.ToInt32(Console.ReadLine());

                            switch (opcionMateria)
                            {
                                case 1:
                                    materias[contador] = "Programacion";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                case 2:
                                    materias[contador] = "Matematica";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                case 3:
                                    materias[contador] = "Expresion de problemas";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Ese materia no existe.");
                                    confirmacion = "S";
                                    break;

                            }
                        } while (confirmacion == "S");
                        Console.Clear();
                        Console.WriteLine("Datos del Alumno:");
                        carrera = "Programacion JAVA";
                        Console.WriteLine($"Nombre:{nombre}\nApellido:{apellido}\nEdad:{edad}\nEmail:{mail}\nCarrera:{carrera}");
                        Console.Write("Materas:");
                        foreach (string i in materias)
                        {
                            Console.Write($"{i}-");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Seleccione las materias que desea agregar.");
                            Console.WriteLine("Materias:");
                            Console.WriteLine("1-Programacion\n2-Matematica\n3-Expresion de problemas");
                            int opcionMateria = Convert.ToInt32(Console.ReadLine());

                            switch (opcionMateria)
                            {
                                case 1:
                                    materias[contador] = "Programacion";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                case 2:
                                    materias[contador] = "Matematica";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                case 3:
                                    materias[contador] = "Expresion de problemas";
                                    contador++;
                                    Console.WriteLine("Ingrese S para confirmar o N para negar.");
                                    Console.WriteLine("Deseea agregar una materia mas?");
                                    confirmacion = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Ese materia no existe.");
                                    confirmacion = "S";
                                    break;

                            }
                        } while (confirmacion == "S");
                        Console.Clear();
                        Console.WriteLine("Datos del Alumno:");
                        carrera = "Programacion PHP";
                        Console.WriteLine($"Nombre:{nombre}\nApellido:{apellido}\nEdad:{edad}\nEmail:{mail}\nCarrera:{carrera}");
                        Console.Write("Materas:");
                        foreach (string i in materias)
                        {
                            Console.Write($"{i}-");
                        }
                        break;
                    default:
                        Console.WriteLine("Error, ese codigo de carrera no existe. Seleccione otro.");
                        opcion = 0;
                        break;
                }
            } while (opcion==0);

            Console.WriteLine("\nPresione una tecla para continuar..");
            Console.ReadKey();
        }
    }
}
