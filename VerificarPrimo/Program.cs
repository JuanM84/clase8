using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, contD = 0;

            Console.WriteLine("Introducir un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contD++;
                }
            }
            if (contD > 2)
            {
                Console.WriteLine("El número no es primo");
                Console.WriteLine("Tiene {0} divisores", contD);

            }
            else
            {
                Console.WriteLine("El número es primo");
            }
            
            Console.ReadLine();
        }
    }
}
