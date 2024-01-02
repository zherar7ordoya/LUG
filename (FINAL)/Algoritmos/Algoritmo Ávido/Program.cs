using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problema: Encontrar la combinación de monedas que devuelve el cambio con la
//           menor cantidad de monedas posible.
// Solución: Utilizar el enfoque ávido seleccionando en cada paso la moneda de
//           mayor valor que sea menor o igual al cambio restante.

namespace Algoritmo_Ávido
{
    internal class Program
    {
        static void Main()
        {
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int target = 520;
            int[] result = MinCoins(coins, target);
            Console.WriteLine("Monedas:\t" + string.Join("\t", coins));
            Console.WriteLine("El vuelto:\t" + target);
            Console.WriteLine("Resultado:\t" + string.Join("\t", result));
            Console.ReadKey();
        }
        public static int[] MinCoins(int[] coins, int target)
        {
            Array.Sort(coins);
            Array.Reverse(coins); // Ordenar las monedas en orden descendente
            int[] result = new int[coins.Length];
            int i = 0;
            while (target > 0 && i < coins.Length)
            {
                if (coins[i] <= target)
                {
                    result[i]++;
                    target -= coins[i];
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
    }
}
