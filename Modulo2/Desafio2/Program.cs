using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            Console.WriteLine("Escriba el primer numero:");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el segundo numero:");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write("La suma es:");
                Console.WriteLine(n1+n2);
                Console.Write("La resta es:");
                Console.WriteLine(n1-n2);
            }
            else
            {
                Console.WriteLine("El producto es:");
                Console.WriteLine(n1*n2);
                Console.WriteLine("El la division es:");
                Console.WriteLine(n2/n1);
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
