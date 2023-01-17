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
            const string contraseña = "Contraseña123";
            string contra;
            for(int i=0;i<3;i++) { 
                Console.WriteLine("Escriba la contraseña:");
                contra = Console.ReadLine();
                if(contra.Equals(contraseña))
                {
                    Console.WriteLine("Bienevenido!!");break;//es la contraseña correcta entonces corto el bucle
                }
                else
                {
                    Console.WriteLine("ERROR, Contraseña incorrecta");
                    if(i==0) {
                        Console.WriteLine("Tiene dos chances!");
                    }
                    else if(i==1) {
                        Console.WriteLine("ATENCION!! ULTIMA OPORTUNIDAD!");
                    }
                    else
                    {
                        Console.WriteLine("Cuenta bloqueada, comuniquese con soporte para volver a activarla");
                    }
                }
            }
        }
    }
}
