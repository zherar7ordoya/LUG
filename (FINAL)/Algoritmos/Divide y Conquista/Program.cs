using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problema: Encontrar el máximo elemento en una matriz.
// Solución: Utilizar el enfoque de divide y conquista para dividir la matriz en
//           subproblemas más pequeños y encontrar el máximo en cada submatriz,
//           luego combinar los máximos para obtener el máximo global.

namespace Divide_y_Conquista
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("El máximo elemento en la matriz es {0}", FindMax(arr, 0, arr.Length - 1));
            Console.ReadKey();
        }
        public static int FindMax(int[] arr, int left, int right)
        {
            if (left == right)
                return arr[left];
            int mid = (left + right) / 2;
            int maxLeft = FindMax(arr, left, mid);
            int maxRight = FindMax(arr, mid + 1, right);
            return Math.Max(maxLeft, maxRight);
        }

    }
}
