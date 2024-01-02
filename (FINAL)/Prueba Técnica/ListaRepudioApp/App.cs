using ListaRepudioLib;

using System;
using System.Diagnostics;

namespace ListaRepudioApp
{
    class App
    {
        /**
         * Cuando Visual Studio te sugiere que declares un campo como readonly,
         * lo está haciendo para resaltar que el campo se inicializa en su
         * declaración o en el constructor de la clase y no se modificará
         * después de eso. Esto ayuda a prevenir errores y garantiza que el
         * valor del campo permanezca constante en todo momento.
         */
        private readonly ListaRepudio listaRepudio;

        public App()
        {
            listaRepudio = new ListaRepudio();
        }

        public void Run()
        {
            try
            {
                // Solicitar al usuario ingresar el nombre del archivo
                Console.Write("Ingrese el nombre del archivo: ");
                string archivo = Console.ReadLine();

                // Cargar las cadenas desde el archivo
                listaRepudio.CargarLista(archivo);

                // Solicitar al usuario ingresar la cadena de búsqueda
                Console.Write("Ingrese la cadena de búsqueda: ");
                string busqueda = Console.ReadLine();

                // Medir el tiempo de ejecución de las operaciones
                var cronometro = new Stopwatch();
                cronometro.Start();

                // Realizar la búsqueda y mostrar el resultado
                bool existe = listaRepudio.Buscar(busqueda, out int posicion);

                cronometro.Stop();
                TimeSpan demora = cronometro.Elapsed;

                if (existe)
                {
                    Console.WriteLine($"EXISTE: Cadena encontrada en la lista de repudio en la posición {posicion + 1}");
                }
                else
                {
                    Console.WriteLine("NO EXISTE: Cadena no encontrada en la lista de repudio.");
                }

                Console.WriteLine($"Tiempo de operaciones: {demora.TotalMilliseconds} milisegundos");
            }
            catch (ListaRepudioException.CargarListaException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (ListaRepudioException.BuscarException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (ListaRepudioException.EsAlfanumericaException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR GENERAL: {ex.Message}");
            }
        }
    }
}
