using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problema: Calcular el n-ésimo número de la secuencia de Fibonacci.
// Solución: Utilizar la programación dinámica para almacenar los valores
//           previamente calculados y evitar recálculos innecesarios.

namespace Programación_Dinámica
{
    internal class Program
    {
        static void Main()
        {
            int n = 5;
            Console.WriteLine("El {0}-ésimo número de la secuencia de Fibonacci es {1}", n, Fibonacci(n));
            Console.ReadKey();
        }
        public static int Fibonacci(int n)
        {
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib[n];
        }

    }
}
