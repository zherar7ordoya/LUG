////////10////////20////////30////////40////////50////////60////////70////////80////////90////////100////////110////////120

using System;
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

            // Ingreso al sistema
            LoginForm login = new LoginForm();

            // Muestra el login y verifica el resultado
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Si el resultado es OK, muestra el formulario del menú
                Application.Run(new MenuForm());
            }
        }
    }
}
