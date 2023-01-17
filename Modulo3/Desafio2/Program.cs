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
         double inversion = 1000;//dinero que invierte una persona
            int mes = 0;
            

            for(int i = 0; i< 12; i++)
            {
                inversion=inversion*1.03;

                if (inversion >= 1200)
                {
                    mes = i; break;//que termine el for
                }
            }
            Console.WriteLine("En {0} meses se consigue ${1:N2}",mes+1,inversion);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
