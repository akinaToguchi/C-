using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            Console.WriteLine("Escriba la primer nota:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba la segunda nota:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if(n1>4 && n2>4)
            {
                Console.WriteLine("Esta aprobado");
            }
            else if(n1<4 && n2>4)
            {
                Console.WriteLine("Esta desaprobado, debe recuperar el primer parcial");
            }
            else
            {
                Console.WriteLine("Esta desaprobado,debe recuperar el segundo parcial");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
