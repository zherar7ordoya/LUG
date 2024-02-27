using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Muestra la pantalla de presentación
            SplashForm splash = new SplashForm();
            splash.Show();

            // Inicia la tarea que carga la interfaz principal
            Task.Run(() =>
            {
                // Simula una carga más larga (2 segundos)
                Thread.Sleep(2000);

                // Cierra la pantalla de presentación desde el hilo de la interfaz de usuario
                splash.Invoke(new Action(() => splash.Close()));

                // Muestra el formulario principal en el hilo de la interfaz de usuario
                Application.Run(new MenuForm());
            });

            // Inicia la aplicación
            Application.Run();
        }
    }
}
