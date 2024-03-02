using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVC
{
    public static class Mensajeria
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MENSAJERÍA

        public static void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static DialogResult MostrarPregunta(string mensaje)
        {
            return MessageBox.Show(
                mensaje,
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public static void MostrarError(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "Advertencia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

    }
}
