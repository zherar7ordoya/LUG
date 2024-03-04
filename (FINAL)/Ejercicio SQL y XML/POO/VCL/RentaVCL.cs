using ABS;
using BEL;
using BLL;
using SVC;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    public partial class RentaVCL
    {
        #region INICIALIZACIÓN

        readonly Form formulario;
        private EstadoFormulario estado = EstadoFormulario.Normal;

        //|||||||||||||||||||||||||||||||||||| LISTA DE CONTROLES DEL FORMULARIO

        // Cliente
        TextBox CodigoClienteTextbox;
        INombreControl NombreControl;
        IApellidoControl ApellidoControl;
        IDniControl DniControl;
        DateTimePicker FechaNacimientoDtp;
        IEmailControl EmailControl;
        DataGridView ClientesDgv;

        // Vehiculo
        TextBox CodigoVehiculoTextbox;
        ComboBox TipoCombobox;
        IMarcaControl MarcaControl;
        IModeloControl ModeloControl;
        IPatenteControl PatenteControl;
        DataGridView VehiculosDgv;

        // Renta
        DataGridView ListadoDgv;
        TextBox CodigoRentaTextbox;
        NumericUpDown DiasRentadosNumeric;
        Button CalcularButton;
        IImporteControl ImporteControl;
        CheckBox ManualCheckbox;
        Button CancelarButton;
        Button GuardarButton;

        // Constructor
        public RentaVCL(Form formulario)
        {
            this.formulario = formulario;
            IncializarControles();
            formulario.Load += FormularioLoad;
        }

        // Inicialización controles
        private void IncializarControles()
        {
            // Cliente
            CodigoClienteTextbox = (TextBox)formulario.Controls["CodigoClienteTextbox"];
            NombreControl = (INombreControl)formulario.Controls["NombreControl"];
            ApellidoControl = (IApellidoControl)formulario.Controls["ApellidoControl"];
            DniControl = (IDniControl)formulario.Controls["DniControl"];
            FechaNacimientoDtp = (DateTimePicker)formulario.Controls["FechaNacimientoDtp"];
            EmailControl = (IEmailControl)formulario.Controls["EmailControl"];
            ClientesDgv = (DataGridView)formulario.Controls["ClientesDgv"];

            // Vehiculo
            CodigoVehiculoTextbox = (TextBox)formulario.Controls["CodigoVehiculoTextbox"];
            TipoCombobox = (ComboBox)formulario.Controls["TipoCombobox"];
            MarcaControl = (IMarcaControl)formulario.Controls["MarcaControl"];
            ModeloControl = (IModeloControl)formulario.Controls["ModeloControl"];
            PatenteControl = (IPatenteControl)formulario.Controls["PatenteControl"];
            VehiculosDgv = (DataGridView)formulario.Controls["VehiculosDgv"];

            // Renta
            ListadoDgv = (DataGridView)formulario.Controls["ListadoDgv"];
            CodigoRentaTextbox = (TextBox)formulario.Controls["CodigoRentaTextbox"];
            DiasRentadosNumeric = (NumericUpDown)formulario.Controls["DiasRentadosNumeric"];
            CalcularButton = (Button)formulario.Controls["CalcularButton"];
            ImporteControl = (IImporteControl)formulario.Controls["ImporteControl"];
            ManualCheckbox = (CheckBox)formulario.Controls["ManualCheckbox"];
            CancelarButton = (Button)formulario.Controls["CancelarButton"];
            GuardarButton = (Button)formulario.Controls["GuardarButton"];
        }

        // Carga del formulario
        private void FormularioLoad(object sender, EventArgs e)
        {
            InicializarEventHandlers();
            ClientesDgv.DataSource = new ClienteBLL().Consultar();
            VehiculosDgv.DataSource = new VehiculoBLL().Consultar();
            Consultar();
        }

        private void InicializarEventHandlers()
        {
            // Botones
            GuardarButton.Click += BotonGuardar;
            CancelarButton.Click += BotonCancelar;
            CalcularButton.Click += BotonCalcular;

            // DataGridViews
            ListadoDgv.RowEnter += SincronizarControles;
            ListadoDgv.CellClick += Borrar;
            ClientesDgv.RowEnter += MostarCliente;
            VehiculosDgv.RowEnter += MostarVehiculo;

            // Controles fundamentales (en los que se basa el estado del formulario)
            CodigoClienteTextbox.TextChanged += CompararDatos;
            CodigoVehiculoTextbox.TextChanged += CompararDatos;
            CodigoVehiculoTextbox.TextChanged += BotonCalcular;
            DiasRentadosNumeric.ValueChanged += BotonCalcular; // El recálculo llamará a CompararDatos
            ImporteControl.TextChanged += CompararDatos;

            // Un "twich"...
            ManualCheckbox.CheckedChanged += (s, e) => ImporteControl.Enabled = ManualCheckbox.Checked;
        }
        #endregion

        private void ConfigurarFormulario()
        {
            bool cliente = CodigoClienteTextbox.Text != string.Empty;
            bool vehiculo = CodigoVehiculoTextbox.Text != string.Empty;
            bool importe = ImporteControl.Validar();

            bool validado = cliente && vehiculo && importe;
            Tool.ConfigurarBotones(formulario, estado, validado);
        }

        #region ||*----------------------------------------------------> EVENTOS

        //|||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE DATAGRIDVIEW

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                CodigoRentaTextbox.Text = renta.Codigo.ToString();
                DiasRentadosNumeric.Value = renta.DiasRentados;
                ImporteControl.Importe = renta.Importe.ToString();
                MostarCliente(sender, e);
                MostarVehiculo(sender, e);
            }
        }

        private void MostarCliente(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = null;

            if (sender == ListadoDgv)
            {
                Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                List<Cliente> clientes = new ClienteBLL().Consultar();
                cliente = clientes.Find(c => c.Codigo == renta.Cliente.Codigo);
            }
            else if (sender == ClientesDgv)
            {
                cliente = (Cliente)ClientesDgv.Rows[e.RowIndex].DataBoundItem;
            }
            if (cliente == null) return;

            CodigoClienteTextbox.Text = cliente.Codigo.ToString();
            NombreControl.Nombre = cliente.Nombre;
            ApellidoControl.Apellido = cliente.Apellido;
            DniControl.Dni = cliente.DNI.ToString();
            FechaNacimientoDtp.Value = cliente.FechaNacimiento;
            EmailControl.Email = cliente.Email;
        }

        private void MostarVehiculo(object sender, DataGridViewCellEventArgs e)
        {
            Vehiculo vehiculo = null;

            if (sender == ListadoDgv)
            {
                Renta renta = (Renta)ListadoDgv.Rows[e.RowIndex].DataBoundItem;
                List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();
                vehiculo = vehiculos.Find(v => v.Codigo == renta.Vehiculo.Codigo);
            }
            else if (sender == VehiculosDgv)
            {
                vehiculo = (Vehiculo)VehiculosDgv.Rows[e.RowIndex].DataBoundItem;
            }
            if (vehiculo == null) return;

            CodigoVehiculoTextbox.Text = vehiculo.Codigo.ToString();
            TipoCombobox.Text = vehiculo.Tipo.ToString();
            MarcaControl.Marca = vehiculo.Marca;
            ModeloControl.Modelo = vehiculo.Modelo;
            PatenteControl.Patente = vehiculo.Patente;
        }

        //|||||||||||||||||||||||||||||||||||||| EVENTOS DE CONTROLES DE USUARIO

        private void CompararDatos(object sender, EventArgs e)
        {
            if (ListadoDgv.CurrentRow != null) // Dato: es null durante el alta
            {
                Renta renta = (Renta)ListadoDgv.SelectedRows[0].DataBoundItem;

                bool modificado = (CodigoClienteTextbox.Text != renta.Cliente.Codigo.ToString()) ||
                                  (CodigoVehiculoTextbox.Text != renta.Vehiculo.Codigo.ToString()) ||
                                  (DiasRentadosNumeric.Value != renta.DiasRentados) ||
                                  (ImporteControl.Importe != renta.Importe.ToString());

                if (modificado) estado = EstadoFormulario.Modificacion;
                else estado = EstadoFormulario.Normal;
            }
            ConfigurarFormulario(); // Actualiza el estado de los botones
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS DE BOTONES

        private void BotonGuardar(object sender, EventArgs e)
        {
            if (estado == EstadoFormulario.Normal)
            {
                Tool.LimpiarFormularioRenta(formulario.Controls);
                estado = EstadoFormulario.Alta;
                ConfigurarFormulario();
                Mensajeria.MostrarInformacion("Complete los campos y luego pulse Guardar");
            }
            else
            {
                if (estado == EstadoFormulario.Alta) Agregar(this, e);
                else if (estado == EstadoFormulario.Modificacion) Modificar(this, e);
            }
        }

        private void BotonCancelar(object sender, EventArgs e)
        {
            DialogResult resultado = Mensajeria.MostrarPregunta("¿Seguro que desea cancelar?");
            if (resultado == DialogResult.Yes)
            {
                estado = EstadoFormulario.Normal;
                Consultar();
                ConfigurarFormulario();
            }
        }

        private void BotonCalcular(object sender, EventArgs e)
        {
            // Tuve que agregar esta condición para controlar que no se dispare
            // el cálculo cuando el formulario está en estado Normal
            if (estado != EstadoFormulario.Normal)
            {
                if (CodigoVehiculoTextbox.Text != string.Empty)
                {
                    List<Vehiculo> vehiculos = new VehiculoBLL().Consultar();

                    // Solo puedo confiar en el vehículo del TextBox (en ninguno de los DataGridView)
                    Vehiculo vehiculo = vehiculos.Find(x => x.Codigo == int.Parse(CodigoVehiculoTextbox.Text));

                    // Calculo el importe de la renta según el tipo de vehículo
                    if (vehiculo is Automovil automovil)
                    {
                        ImporteControl.Importe =
                            new AutomovilBLL()
                            .CalcularRenta(automovil, (int)DiasRentadosNumeric.Value)
                            .ToString("0.00");
                    }
                    else if (vehiculo is Camion camion)
                    {
                        ImporteControl.Importe =
                            new CamionBLL()
                            .CalcularRenta(camion, (int)DiasRentadosNumeric.Value)
                            .ToString("0.00");
                    }
                    else if (vehiculo is Camioneta camioneta)
                    {
                        ImporteControl.Importe =
                            new CamionetaBLL()
                            .CalcularRenta(camioneta, (int)DiasRentadosNumeric.Value)
                            .ToString("0.00");
                    }
                    else if (vehiculo is Suv suv)
                    {
                        ImporteControl.Importe =
                            new SuvBLL()
                            .CalcularRenta(suv, (int)DiasRentadosNumeric.Value)
                            .ToString("0.00");
                    }

                    // Forzar la actualización del control (o CompararDatos fallará)
                    ImporteControl.Update();

                    // Comprobar si el formulario necesita cambiar de estado (modificación)
                    CompararDatos(this, e);
                }
            }
        }
        #endregion
    }
}
