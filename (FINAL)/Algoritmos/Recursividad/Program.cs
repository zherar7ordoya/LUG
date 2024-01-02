using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problema: Calcular el factorial de un número entero no negativo.
// Solución: Utilizar una función recursiva que calcule el factorial del número.

namespace Recursividad
{
    internal class Program
    {
        static void Main()
        {
            int n = 5;
            Console.WriteLine("El factorial de {0} es {1}", n, Factorial(n));
            Console.ReadKey();
        }
        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

    }
}
