using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarPrimo
{
    internal class Program
    {
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
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contD++;
                    }
                }
                if (contD <= 2)
                {
                    Console.WriteLine("El número {0} es primo", i);
                    primos++;
                }
                contD = 0;
            }
            Console.WriteLine("-- Hay {0} entre {1} y {2} --", primos, desde, hasta);
            Console.ReadKey();
        }
    }
}
