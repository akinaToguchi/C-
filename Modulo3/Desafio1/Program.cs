using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inversion= 1000;//dinero que invierte una persona
            

            for(int i = 0; i < 12; i++)
            {
                inversion=inversion*1.02;
            }
            Console.WriteLine("El dinero total luego de un año es: {0:n2}", inversion);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
