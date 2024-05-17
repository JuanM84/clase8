using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimo
{
    internal class Program
    {
        static bool VerificarPrimo(int num)
        {
            int contD = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contD++;
                }
            }
            return (contD <= 2);
        }
        static void Main(string[] args)
        {
            int desde, hasta, contD=0, primos=0;
            Console.WriteLine("---GENERADOR DE NÚMEROS PRIMOS---");
            Console.WriteLine("Ingres desde que número buscar: ");
            desde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingres hasta que número buscar: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            for(int i = desde; i <= hasta; i++)
            {
                if (VerificarPrimo(i))
                {
                    Console.WriteLine("El número {0} es primo", i);
                    primos++;
                }
            }
            Console.WriteLine("-- Hay {0} entre {1} y {2} --", primos, desde, hasta);
            Console.ReadKey();
        }
    }
}
