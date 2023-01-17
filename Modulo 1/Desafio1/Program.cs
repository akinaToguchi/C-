using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool n1 = true, n2 = false, n3 = true;
            Console.WriteLine(" n1 ^ n2= " + (n1 ^ n2));
            Console.WriteLine("(n1 & !n2) | n3= " + ((n1 & !n2) | n3));
            Console.WriteLine("(n1 | n2) & !n3= " + ((n1 | n2) & !n3));
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
