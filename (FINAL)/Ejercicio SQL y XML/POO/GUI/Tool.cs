using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class Tool
    {
        public static void Limpiar(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TableLayoutPanel panel)
                {
                    LimpiarTableLayoutPanel(panel);
                }

                if (control is DataGridView) (control as DataGridView).DataSource = null;
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) control.Text = DateTime.Now.ToString();
            }
        }

        private static void LimpiarTableLayoutPanel(TableLayoutPanel tableLayoutPanel)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) control.Text = DateTime.Now.ToString();
            }
        }


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





        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
