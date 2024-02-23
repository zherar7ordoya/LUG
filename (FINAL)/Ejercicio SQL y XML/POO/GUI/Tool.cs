using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GUI
{
    public static class Tool
    {

        #region HERRAMIENTAS GENÉRICAS -Configuración del Form y MessageBoxes-

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

        #endregion

        #region HERRAMIENTAS ESPECÍFICAS DE CLIENTE

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
                        if (ctrl is TextBox) ctrl.Text = "";
                        if (ctrl is NombreControl) ((NombreControl)ctrl).Nombre = "";
                        if (ctrl is ApellidoControl) ((ApellidoControl)ctrl).Apellido = "";
                        if (ctrl is DniControl) ((DniControl)ctrl).Dni = "";
                        if (ctrl is DateTimePicker) ctrl.Text = DateTime.Now.ToString();
                        if (ctrl is EmailControl) ((EmailControl)ctrl).Email = "";
                    }
                }
            }
        }


        public static Cliente ArmarObjetoCliente(ClienteForm formulario)
        {
            Cliente cliente = new Cliente();

            if (string.IsNullOrEmpty(formulario.CodigoTextbox.Text)) cliente.Codigo = 0; // Es un alta
            else cliente.Codigo = int.Parse(formulario.CodigoTextbox.Text);

            cliente.Nombre = formulario.NombreControl.Nombre;
            cliente.Apellido = formulario.ApellidoControl.Apellido;
            cliente.DNI = int.Parse(formulario.DniControl.Dni);
            cliente.FechaNacimiento = DateTime.Parse(formulario.FechaNacimientoDtp.Text);
            cliente.Email = formulario.EmailControl.Email;

            return cliente;
        }

        #endregion

        #region HERRAMIENTAS ESPECÍFICAS DE RENTA

        public static void LimpiarFormularioRenta(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView dgv)
                {
                    // Solo al DatarGridView principal (ListadoDgv para rentas)
                    if (dgv.Columns.Contains("Baja"))
                    {
                        dgv.DataSource = null;
                        dgv.Columns.Remove("Baja");
                    }
                }

                if (control is TableLayoutPanel panel)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        // Comunes a todos los paneles
                        if (ctrl is TextBox) ctrl.Text = "";
                        if (ctrl is DateTimePicker) ctrl.Text = DateTime.Now.ToString();
                        if (ctrl is NumericUpDown) ((NumericUpDown)ctrl).Value = 1;
                        if (ctrl is ComboBox) ctrl.Text = "";

                        // Panel de Renta
                        if (ctrl is ImporteControl) ((ImporteControl)ctrl).Importe = "0";

                        // Panel de Cliente
                        if (ctrl is NombreControl) ((NombreControl)ctrl).Nombre = "";
                        if (ctrl is ApellidoControl) ((ApellidoControl)ctrl).Apellido = "";
                        if (ctrl is DniControl) ((DniControl)ctrl).Dni = "";
                        if (ctrl is EmailControl) ((EmailControl)ctrl).Email = "";

                        // Panel de Vehículo
                        if (ctrl is MarcaControl) ((MarcaControl)ctrl).Marca = "";
                        if (ctrl is ModeloControl) ((ModeloControl)ctrl).Modelo = "";
                        if (ctrl is PatenteControl) ((PatenteControl)ctrl).Patente = "";
                    }
                }
            }
        }


        public static Renta ArmarObjetoRenta(RentaForm formulario)
        {
            Renta renta = new Renta();

            // Código: si es un alta, el código es 0
            if (string.IsNullOrEmpty(formulario.CodigoRentaTextbox.Text)) renta.Codigo = 0;
            else renta.Codigo = int.Parse(formulario.CodigoRentaTextbox.Text);

            // Ahora, la propiedad Cliente
            List<Cliente> clientes = new ClienteBLL().Consultar();
            renta.Cliente =
                clientes
                .Find(x => formulario.CodigoClienteTextbox.Text == x.Codigo.ToString());

            // Ahora, la propiedad Vehículo
            List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();
            renta.Vehiculo =
                vehiculos
                .Find(x => formulario.CodigoVehiculoTextbox.Text == x.Codigo.ToString());

            // Los días rentados (que no puede ser 0:solucionado con el control Numeric)
            renta.DiasRentados = (int)formulario.DiasRentadosNumeric.Value;

            // El importe (que no puede ser 0: solucionado con la validación)
            renta.Importe = decimal.Parse(formulario.ImporteControl.Importe);

            // Listo
            return renta;
        }

        #endregion

        #region HERRAMIENTAS ESPECÍFICAS DE VEHÍCULO

        public static void LimpiarFormularioVehiculo(this Control.ControlCollection controls)
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
                        if (ctrl is TextBox) ctrl.Text = "";
                        if (ctrl is ComboBox) ctrl.Text = "Automovil";
                        if (ctrl is MarcaControl) ((MarcaControl)ctrl).Marca = "";
                        if (ctrl is ModeloControl) ((ModeloControl)ctrl).Modelo = "";
                        if (ctrl is PatenteControl) ((PatenteControl)ctrl).Patente = "";
                    }
                }
            }
        }


        public static Vehiculo ArmarObjetoVehiculo(VehiculoForm formulario)
        {
            Vehiculo vehiculo;
            string tipo = formulario.TipoCombobox.SelectedValue.ToString();

            switch (tipo)
            {
                case "Automovil":
                    vehiculo = new Automovil();
                    break;
                case "Camion":
                    vehiculo = new Camion();
                    break;
                case "Camioneta":
                    vehiculo = new Camioneta();
                    break;
                case "Suv":
                    vehiculo = new Suv();
                    break;
                default:
                    throw new InvalidOperationException($"Tipo de vehículo desconocido: {tipo}");
            }

            if (string.IsNullOrEmpty(formulario.CodigoTextbox.Text)) vehiculo.Codigo = 0;
            else vehiculo.Codigo = int.Parse(formulario.CodigoTextbox.Text);
            vehiculo.Tipo = (VehiculoTipo)formulario.TipoCombobox.SelectedValue;
            vehiculo.Marca = formulario.MarcaControl.Marca;
            vehiculo.Modelo = formulario.ModeloControl.Modelo;
            vehiculo.Patente = formulario.PatenteControl.Patente;

            return vehiculo;
        }

        #endregion
    }
}
