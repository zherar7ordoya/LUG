﻿using System;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Esta es una clase de utilidades para todas las ventanas.
    /// </summary>
    public static class Tool
    {
        #region Limpieza de controles
        public static void LimpiarControlesEstandar(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TableLayoutPanel panel)
                {
                    LimpiarControlesEstandarTableLayoutPanel(panel);
                }

                if (control is DataGridView) (control as DataGridView).DataSource = null;
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) control.Text = DateTime.Now.ToString();
            }
        }

        private static void LimpiarControlesEstandarTableLayoutPanel(TableLayoutPanel tableLayoutPanel)
        {
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) control.Text = DateTime.Now.ToString();
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