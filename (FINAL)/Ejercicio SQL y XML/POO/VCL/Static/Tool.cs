using ABS;
using System;
using System.Windows.Forms;


namespace VCL
{
    public static class Tool
    {
        //||||||||||||||||||||||||||||||||||||||||| CONFIGURACIÓN DE FORMULARIOS

        public static void ConfigurarBotones(Form formulario, EstadoFormulario estado, bool validado)
        {
            Button guardarButton = (Button)formulario.Controls["GuardarButton"];
            Button cancelarButton = (Button)formulario.Controls["CancelarButton"];

            switch (estado)
            {
                case EstadoFormulario.Normal:
                    guardarButton.Text = "Alta";
                    cancelarButton.Visible = false;
                    break;
                case EstadoFormulario.Alta:
                case EstadoFormulario.Modificacion:
                    guardarButton.Text = "Guardar";
                    cancelarButton.Visible = true;
                    break;
            }
            guardarButton.Visible = validado;
        }
        
        //|||||||||||||||||||||||||||||||||||||||||||||| LIMPIEZA DE FORMULARIOS

        public static void LimpiarFormularioCliente(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.DataSource = null;
                    if (dgv.Columns.Contains("Baja")) dgv.Columns.Remove("Baja");
                }

                if (control is TextBox) control.Text = "";
                if (control is INombreControl nombre) nombre.Nombre = "";
                if (control is IApellidoControl apellido) apellido.Apellido = "";
                if (control is IDniControl dni) dni.Dni = "";
                if (control is DateTimePicker) control.Text = DateTime.Now.ToString();
                if (control is IEmailControl email) email.Email = "";
            }
        }


        public static void LimpiarFormularioRenta(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView dgv)
                {
                    // Solo al DGV principal (ListadoDgv para RentaForm)
                    if (dgv.Columns.Contains("Baja"))
                    {
                        dgv.DataSource = null;
                        dgv.Columns.Remove("Baja");
                    }
                }

                // Comunes a todos los paneles
                if (control is TextBox) control.Text = "";
                if (control is DateTimePicker) control.Text = DateTime.Now.ToString();
                if (control is NumericUpDown numerico) numerico.Value = 1;
                if (control is ComboBox) control.Text = "";

                // Panel de Renta
                if (control is IImporteControl importe) importe.Importe = "0";

                // Panel de Cliente
                if (control is INombreControl nombre) nombre.Nombre = "";
                if (control is IApellidoControl apellido) apellido.Apellido = "";
                if (control is IDniControl dni) dni.Dni = "";
                if (control is IEmailControl email) email.Email = "";

                // Panel de Vehículo
                if (control is IMarcaControl marca) marca.Marca = "";
                if (control is IModeloControl modelo) modelo.Modelo = "";
                if (control is IPatenteControl patente) patente.Patente = "";
            }
        }


        public static void LimpiarFormularioVehiculo(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView dgv)
                {
                    dgv.DataSource = null;
                    if (dgv.Columns.Contains("Baja")) dgv.Columns.Remove("Baja");
                }

                if (control is TextBox) control.Text = "";
                if (control is ComboBox) control.Text = "Automovil";
                if (control is IMarcaControl marca) marca.Marca = "";
                if (control is IModeloControl modelo) modelo.Modelo = "";
                if (control is IPatenteControl patente) patente.Patente = "";
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
