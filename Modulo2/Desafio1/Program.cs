using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                /*
                 * Pedir por teclado una nota (entera) calcular y mostrar:
                 * si la nota es mayor o igual a 4 y menor  a 7: RINDE FINAL
                 * si la nota es 7,8, 9 o 10: PROMOCIONA LA MATERIA
                 * si la nota es menor a 4 SIN IMPORTAR LA ASISTENCIA: RECURSA LA MATERIA
                 */

                // ************** variables y constantes
                int intNota = 0;
                const int NOTA_FINAL = 7;
                const int NOTA_PROMOCION = 7;
                const int NOTA_RECURSA = 4;
                string strCalificacion = "";

                // ************** captura de datos
                Console.Write("Ingrese nota \n(1 a 10): ");
                // dblNota = Convert.ToDouble(Console.ReadLine());
                intNota = Convert.ToInt32(Console.ReadLine());

                // ************** resolución
                if (intNota >= NOTA_RECURSA && intNota < NOTA_FINAL)
                {
                    strCalificacion = "RINDE FINAL";
                }

                //if (intNota == 8 && intNota == 9 && intNota == 10) 
                if (intNota >= NOTA_PROMOCION)
                {
                    strCalificacion = "PROMOCIONA MATERIA";
                }

                if (intNota < NOTA_RECURSA)
                {
                    strCalificacion = "RECURSA MATERIA";
                }

                // ************** mostrar resultados
                Console.WriteLine($"\nNota ingresada: {intNota}, el alumno: {strCalificacion}");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
        }
 }
