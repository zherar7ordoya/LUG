using System;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Esta es una clase de utilidades para todas las ventanas.
    /// </summary>
    public static class Tool
    {
        #region Limpieza de controles
        public static void LimpiarFormularioCliente(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.DataSource = null;
                    if (dgv.Columns.Contains("Baja")) dgv.Columns.Remove("Baja");
                }

                if (control is TableLayoutPanel panel)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        if (ctrl is NombreControl) ((NombreControl)ctrl).Nombre = "";
                        if (ctrl is ApellidoControl) ((ApellidoControl)ctrl).Apellido = "";
                        if (ctrl is DniControl) ((DniControl)ctrl).Dni = "";
                        if (ctrl is DateTimePicker) ctrl.Text = DateTime.Now.ToString();
                        if (ctrl is EmailControl) ((EmailControl)ctrl).Email = "";
                    }
                }
            }
        }


        
        #endregion

        #region Mensajes (MessageBox)
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
        #endregion

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
